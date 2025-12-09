using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DevNooTools
{
    public class DatabaseHelper
    {
        private readonly string jsonFilePath;

        public DatabaseHelper(string filePath = null)
        {
            jsonFilePath = filePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");
        }

        public string DatabasePath => jsonFilePath;

        public List<Product> LoadProducts()
        {
            try
            {
                if (!File.Exists(jsonFilePath))
                    return new List<Product>();

                var json = File.ReadAllText(jsonFilePath, Encoding.UTF8);
                return ParseProductsFromJson(json);
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
                var dir = Path.GetDirectoryName(jsonFilePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var json = SerializeProductsToJson(products);
                File.WriteAllText(jsonFilePath, json, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar dados no arquivo JSON: {ex.Message}", ex);
            }
        }

        private string EscapeJsonString(string s)
        {
            if (s == null) return "";
            return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r");
        }

        private string SerializeProductsToJson(List<Product> products)
        {
            var sb = new StringBuilder();
            sb.AppendLine("[");
            bool first = true;
            foreach (var p in products)
            {
                if (!first) sb.AppendLine(",");
                first = false;
                sb.AppendLine("  {");
                sb.AppendFormat("    \"id\": \"{0}\",\n", p.Id.ToString());
                sb.AppendFormat("    \"name\": \"{0}\",\n", EscapeJsonString(p.Name));
                sb.AppendFormat("    \"description\": \"{0}\",\n", EscapeJsonString(p.Description));
                sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, "    \"price\": {0},\n", p.Price);
                sb.AppendFormat("    \"quantity\": {0}\n", p.Quantity);
                sb.Append("  }");
            }
            sb.AppendLine();
            sb.Append("]");
            return sb.ToString();
        }

        private List<Product> ParseProductsFromJson(string json)
        {
            var list = new List<Product>();
            if (string.IsNullOrWhiteSpace(json)) return list;

            var objMatches = Regex.Matches(json, @"\{[^}]*\}");
            foreach (Match m in objMatches)
            {
                var obj = m.Value;
                var id = MatchStringField(obj, "id");
                var name = MatchStringField(obj, "name");
                var desc = MatchStringField(obj, "description");
                var priceStr = MatchNumberField(obj, "price");
                var qtyStr = MatchNumberField(obj, "quantity");

                decimal price = 0m; int qty = 0;
                decimal.TryParse(priceStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out price);
                int.TryParse(qtyStr, out qty);

                var prod = new Product
                {
                    Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid() : Guid.TryParse(id, out var gid) ? gid : Guid.NewGuid(),
                    Name = name,
                    Description = desc,
                    Price = price,
                    Quantity = qty
                };
                list.Add(prod);
            }

            return list;
        }

        private string MatchStringField(string obj, string field)
        {
            var pat = "\"" + field + "\"\\s*:\\s*\"([^\"]*)\"";
            var m = Regex.Match(obj, pat);
            return m.Success ? UnescapeJsonString(m.Groups[1].Value) : string.Empty;
        }

        private string MatchNumberField(string obj, string field)
        {
            var pat = "\"" + field + "\"\\s*:\\s*([0-9+\\-eE\\.]+)";
            var m = Regex.Match(obj, pat);
            return m.Success ? m.Groups[1].Value : "0";
        }

        private string UnescapeJsonString(string s)
        {
            return s.Replace("\\\"", "\"").Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\\\", "\\");
        }
    }
}
