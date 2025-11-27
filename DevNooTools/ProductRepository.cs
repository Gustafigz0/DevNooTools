using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DevNooTools
{
    public class ProductRepository
    {
        private readonly string filePath;
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

        public ProductRepository(string filePath = null)
        {
            this.filePath = filePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.xml");
        }

        public List<Product> LoadAll()
        {
            try
            {
                if (!File.Exists(filePath))
                    return new List<Product>();

                using (var fs = File.OpenRead(filePath))
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

        public void SaveAll(List<Product> products)
        {
            var dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using (var fs = File.Create(filePath))
            {
                serializer.Serialize(fs, products);
            }
        }
    }
}
