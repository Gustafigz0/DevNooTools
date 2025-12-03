using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DevNooTools
{
    public class ProductRepository
    {
        private readonly string xmlFilePath;
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        private readonly DatabaseHelper dbHelper;
        private readonly bool useJson;

        public ProductRepository(bool useJson = true, string xmlFilePath = null)
        {
            this.useJson = useJson;
            this.xmlFilePath = xmlFilePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.xml");
            
            if (useJson)
            {
                dbHelper = new DatabaseHelper();
                MigrateFromXmlIfNeeded();
            }
        }

        public string DatabasePath => useJson && dbHelper != null ? dbHelper.DatabasePath : null;

        public List<Product> LoadAll()
        {
            if (useJson)
            {
                return dbHelper.LoadProducts();
            }
            else
            {
                return LoadFromXml();
            }
        }

        public void SaveAll(List<Product> products)
        {
            if (useJson)
            {
                dbHelper.SaveProducts(products);
            }
            else
            {
                SaveToXml(products);
            }
        }

        private void MigrateFromXmlIfNeeded()
        {
            try
            {
                // Check if JSON database is empty
                var existingProducts = dbHelper.LoadProducts();
                
                // If database is empty and XML file exists, migrate data
                if (existingProducts.Count == 0 && File.Exists(xmlFilePath))
                {
                    var xmlProducts = LoadFromXml();
                    if (xmlProducts.Count > 0)
                    {
                        dbHelper.SaveProducts(xmlProducts);
                        
                        // Backup the XML file
                        string backupPath = xmlFilePath + ".backup";
                        File.Copy(xmlFilePath, backupPath, true);
                    }
                }
            }
            catch
            {
                // Migration is optional, continue even if it fails
            }
        }

        #region XML Methods (Legacy)

        private List<Product> LoadFromXml()
        {
            try
            {
                if (!File.Exists(xmlFilePath))
                    return new List<Product>();

                using (var fs = File.OpenRead(xmlFilePath))
                {
                    var obj = serializer.Deserialize(fs) as List<Product>;
                    return obj ?? new List<Product>();
                }
            }
            catch
            {
                return new List<Product>();
            }
        }

        private void SaveToXml(List<Product> products)
        {
            var dir = Path.GetDirectoryName(xmlFilePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using (var fs = File.Create(xmlFilePath))
            {
                serializer.Serialize(fs, products);
            }
        }

        #endregion
    }
}
