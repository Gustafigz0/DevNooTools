using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DevNooTools
{
    public class DatabaseHelper
    {
        private readonly string dbPath;
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

        public DatabaseHelper(string dbFileName = "devnootools_data.xml")
        {
            dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbFileName);
        }

        public string DatabasePath => dbPath;

        public List<Product> LoadProducts()
        {
            try
            {
                if (!File.Exists(dbPath))
                    return new List<Product>();

                using (var fs = File.OpenRead(dbPath))
                {
                    var result = serializer.Deserialize(fs) as List<Product>;
                    return result ?? new List<Product>();
                }
            }
            catch
            {
                return new List<Product>();
            }
        }

        public void SaveProducts(List<Product> products)
        {
            try
            {
                var dir = Path.GetDirectoryName(dbPath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                using (var fs = File.Create(dbPath))
                {
                    serializer.Serialize(fs, products);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar dados: {ex.Message}", ex);
            }
        }
    }
}
