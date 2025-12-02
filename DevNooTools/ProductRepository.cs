using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Xml.Serialization;

namespace DevNooTools
{
    public class ProductRepository
    {
        private readonly string xmlFilePath;
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        private readonly DatabaseHelper dbHelper;
        private readonly bool useSQLite;

        public ProductRepository(bool useSQLite = true, string xmlFilePath = null)
        {
            this.useSQLite = useSQLite;
            this.xmlFilePath = xmlFilePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.xml");
            
            if (useSQLite)
            {
                dbHelper = new DatabaseHelper();
                MigrateFromXmlIfNeeded();
            }
        }

        public string DatabasePath => useSQLite && dbHelper != null ? dbHelper.DatabasePath : null;

        public List<Product> LoadAll()
        {
            if (useSQLite)
            {
                return LoadFromSQLite();
            }
            else
            {
                return LoadFromXml();
            }
        }

        public void SaveAll(List<Product> products)
        {
            if (useSQLite)
            {
                SaveToSQLite(products);
            }
            else
            {
                SaveToXml(products);
            }
        }

        #region SQLite Methods

        private List<Product> LoadFromSQLite()
        {
            var products = new List<Product>();

            try
            {
                using (var connection = dbHelper.GetConnection())
                {
                    string query = "SELECT Id, Name, Description, Price, Quantity FROM Products";
                    
                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                Id = Guid.Parse(reader["Id"].ToString()),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"]?.ToString() ?? string.Empty,
                                Price = Convert.ToDecimal(reader["Price"]),
                                Quantity = Convert.ToInt32(reader["Quantity"])
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar produtos do banco de dados: {ex.Message}", ex);
            }

            return products;
        }

        private void SaveToSQLite(List<Product> products)
        {
            try
            {
                using (var connection = dbHelper.GetConnection())
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Clear existing products
                        using (var deleteCommand = new SQLiteCommand("DELETE FROM Products", connection, transaction))
                        {
                            deleteCommand.ExecuteNonQuery();
                        }

                        // Insert all products
                        string insertQuery = @"
                            INSERT INTO Products (Id, Name, Description, Price, Quantity)
                            VALUES (@Id, @Name, @Description, @Price, @Quantity)";

                        foreach (var product in products)
                        {
                            using (var command = new SQLiteCommand(insertQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", product.Id.ToString());
                                command.Parameters.AddWithValue("@Name", product.Name ?? string.Empty);
                                command.Parameters.AddWithValue("@Description", product.Description ?? string.Empty);
                                command.Parameters.AddWithValue("@Price", product.Price);
                                command.Parameters.AddWithValue("@Quantity", product.Quantity);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar produtos no banco de dados: {ex.Message}", ex);
            }
        }

        private void MigrateFromXmlIfNeeded()
        {
            try
            {
                // Check if SQLite database is empty
                using (var connection = dbHelper.GetConnection())
                {
                    string countQuery = "SELECT COUNT(*) FROM Products";
                    using (var command = new SQLiteCommand(countQuery, connection))
                    {
                        long count = (long)command.ExecuteScalar();
                        
                        // If database is empty and XML file exists, migrate data
                        if (count == 0 && File.Exists(xmlFilePath))
                        {
                            var xmlProducts = LoadFromXml();
                            if (xmlProducts.Count > 0)
                            {
                                SaveToSQLite(xmlProducts);
                                
                                // Backup the XML file
                                string backupPath = xmlFilePath + ".backup";
                                File.Copy(xmlFilePath, backupPath, true);
                            }
                        }
                    }
                }
            }
            catch
            {
                // Migration is optional, continue even if it fails
            }
        }

        #endregion

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
