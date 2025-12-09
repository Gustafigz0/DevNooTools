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

        public ProductRepository(string jsonFilePath = null)
        {
            this.xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.xml");
            dbHelper = new DatabaseHelper(jsonFilePath);
            MigrateFromXmlIfNeeded();
        }

        public string DatabasePath => dbHelper?.DatabasePath;

        public List<Product> LoadAll()
        {
            return dbHelper.LoadProducts();
        }

        public void SaveAll(List<Product> products)
        {
            dbHelper.SaveProducts(products);
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

        #endregion
    }
}
