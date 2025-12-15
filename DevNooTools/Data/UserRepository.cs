using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DevNooTools.Models;

namespace DevNooTools.Data
{
    public class UserRepository
    {
        private readonly string dataFilePath;
        private UserData userData;

        public User CurrentUser { get; private set; }

        public UserRepository(string filePath = null)
        {
            dataFilePath = filePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userdata.json");
            LoadUserData();
        }

        public string DatabasePath => dataFilePath;

        private void LoadUserData()
        {
            try
            {
                if (!File.Exists(dataFilePath))
                {
                    userData = new UserData();
                    // Create default admin user
                    var admin = new User("admin", "admin123", "Administrador") { Role = "Administrador" };
                    userData.Users.Add(admin);
                    userData.UserProducts[admin.Id.ToString()] = new List<Product>();
                    SaveUserData();
                    return;
                }

                var json = File.ReadAllText(dataFilePath, Encoding.UTF8);
                userData = ParseUserDataFromJson(json);
            }
            catch
            {
                userData = new UserData();
                var admin = new User("admin", "admin123", "Administrador") { Role = "Administrador" };
                userData.Users.Add(admin);
                userData.UserProducts[admin.Id.ToString()] = new List<Product>();
                SaveUserData();
            }

            NormalizeAllProductIds();
        }

        public bool Login(string username, string password)
        {
            var user = FindUserByUsername(username);
            if (user != null && user.ValidatePassword(password))
            {
                user.LastLoginAt = DateTime.Now;
                CurrentUser = user;
                SaveUserData();
                return true;
            }
            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public bool Register(string username, string password, string displayName)
        {
            if (FindUserByUsername(username) != null)
                return false;

            var user = new User(username, password, displayName);
            userData.Users.Add(user);
            userData.UserProducts[user.Id.ToString()] = new List<Product>();
            SaveUserData();
            return true;
        }

        public User FindUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return null;
            foreach (var user in userData.Users)
            {
                if (string.Equals(user.Username, username, StringComparison.OrdinalIgnoreCase))
                    return user;
            }
            return null;
        }

        public List<Product> GetUserProducts()
        {
            if (CurrentUser == null) return new List<Product>();
            
            var userId = CurrentUser.Id.ToString();
            if (!userData.UserProducts.ContainsKey(userId))
                userData.UserProducts[userId] = new List<Product>();
            
            EnsureProductIds(userId);
            return userData.UserProducts[userId];
        }

        public void SaveUserProducts(List<Product> products)
        {
            if (CurrentUser == null) return;
            
            var userId = CurrentUser.Id.ToString();
            userData.UserProducts[userId] = products;
            EnsureProductIds(userId);
            SaveUserData();
        }

        public int GetNextProductId()
        {
            var products = GetUserProducts();
            if (products.Count == 0) return 1;
            return products.Max(p => p.Id) + 1;
        }

        private void SaveUserData()
        {
            try
            {
                var dir = Path.GetDirectoryName(dataFilePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var json = SerializeUserDataToJson(userData);
                File.WriteAllText(dataFilePath, json, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar dados: {ex.Message}", ex);
            }
        }

        private void NormalizeAllProductIds()
        {
            if (userData == null) return;
            foreach (var key in userData.UserProducts.Keys.ToList())
            {
                EnsureProductIds(key);
            }
        }

        private void EnsureProductIds(string userId)
        {
            if (!userData.UserProducts.TryGetValue(userId, out var products))
            {
                products = new List<Product>();
                userData.UserProducts[userId] = products;
            }

            var used = new HashSet<int>();
            int nextId = 1;
            foreach (var product in products)
            {
                if (product.Id <= 0 || used.Contains(product.Id))
                {
                    while (used.Contains(nextId))
                        nextId++;
                    product.Id = nextId;
                }

                used.Add(product.Id);
                if (product.Id >= nextId)
                    nextId = product.Id + 1;
            }
        }

        #region JSON Serialization

        private string EscapeJsonString(string s)
        {
            if (s == null) return "";
            return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r");
        }

        private string SerializeUserDataToJson(UserData data)
        {
            var sb = new StringBuilder();
            sb.AppendLine("{");
            
            // Users array
            sb.AppendLine("  \"users\": [");
            for (int i = 0; i < data.Users.Count; i++)
            {
                var u = data.Users[i];
                sb.AppendLine("    {");
                sb.AppendFormat("      \"id\": \"{0}\",\n", u.Id);
                sb.AppendFormat("      \"username\": \"{0}\",\n", EscapeJsonString(u.Username));
                sb.AppendFormat("      \"passwordHash\": \"{0}\",\n", EscapeJsonString(u.PasswordHash));
                sb.AppendFormat("      \"displayName\": \"{0}\",\n", EscapeJsonString(u.DisplayName));
                sb.AppendFormat("      \"role\": \"{0}\",\n", EscapeJsonString(u.Role));
                sb.AppendFormat("      \"createdAt\": \"{0:o}\",\n", u.CreatedAt);
                sb.AppendFormat("      \"lastLoginAt\": {0}\n", u.LastLoginAt.HasValue ? $"\"{u.LastLoginAt:o}\"" : "null");
                sb.Append("    }");
                if (i < data.Users.Count - 1) sb.Append(",");
                sb.AppendLine();
            }
            sb.AppendLine("  ],");

            // UserProducts dictionary
            sb.AppendLine("  \"userProducts\": {");
            int productIdx = 0;
            foreach (var kvp in data.UserProducts)
            {
                sb.AppendFormat("    \"{0}\": [\n", kvp.Key);
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    var p = kvp.Value[i];
                    sb.AppendLine("      {");
                    sb.AppendFormat("        \"id\": {0},\n", p.Id);
                    sb.AppendFormat("        \"name\": \"{0}\",\n", EscapeJsonString(p.Name));
                    sb.AppendFormat("        \"description\": \"{0}\",\n", EscapeJsonString(p.Description));
                    sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, "        \"price\": {0},\n", p.Price);
                    sb.AppendFormat("        \"quantity\": {0}\n", p.Quantity);
                    sb.Append("      }");
                    if (i < kvp.Value.Count - 1) sb.Append(",");
                    sb.AppendLine();
                }
                sb.Append("    ]");
                productIdx++;
                if (productIdx < data.UserProducts.Count) sb.Append(",");
                sb.AppendLine();
            }
            sb.AppendLine("  }");
            
            sb.AppendLine("}");
            return sb.ToString();
        }

        private UserData ParseUserDataFromJson(string json)
        {
            var data = new UserData();
            if (string.IsNullOrWhiteSpace(json)) return data;

            try
            {
                // Parse users
                var usersMatch = Regex.Match(json, @"""users""\s*:\s*\[(.*?)\]", RegexOptions.Singleline);
                if (usersMatch.Success)
                {
                    var usersJson = usersMatch.Groups[1].Value;
                    var userMatches = Regex.Matches(usersJson, @"\{[^{}]*\}", RegexOptions.Singleline);
                    foreach (Match m in userMatches)
                    {
                        var obj = m.Value;
                        var user = new User
                        {
                            Id = ParseGuid(MatchStringField(obj, "id")),
                            Username = MatchStringField(obj, "username"),
                            PasswordHash = MatchStringField(obj, "passwordHash"),
                            DisplayName = MatchStringField(obj, "displayName"),
                            Role = MatchStringField(obj, "role"),
                            CreatedAt = ParseDateTime(MatchStringField(obj, "createdAt")),
                            LastLoginAt = ParseNullableDateTime(MatchStringField(obj, "lastLoginAt"))
                        };
                        data.Users.Add(user);
                    }
                }

                // Parse user products
                var userProductsMatch = Regex.Match(json, @"""userProducts""\s*:\s*\{(.*)\}\s*\}", RegexOptions.Singleline);
                if (userProductsMatch.Success)
                {
                    var userProductsJson = userProductsMatch.Groups[1].Value;
                    var keyMatches = Regex.Matches(userProductsJson, @"""([a-f0-9\-]{36})""\s*:\s*(\[[^\]]*\])", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match km in keyMatches)
                    {
                        var userId = km.Groups[1].Value;
                        var productsJson = km.Groups[2].Value;
                        var products = new List<Product>();

                        var productMatches = Regex.Matches(productsJson, @"\{[^{}]*\}", RegexOptions.Singleline);
                        foreach (Match pm in productMatches)
                        {
                            var obj = pm.Value;
                            var product = new Product
                            {
                                Id = ParseProductId(MatchStringField(obj, "id"), MatchNumberField(obj, "id")),
                                Name = MatchStringField(obj, "name"),
                                Description = MatchStringField(obj, "description"),
                                Price = ParseDecimal(MatchNumberField(obj, "price")),
                                Quantity = ParseInt(MatchNumberField(obj, "quantity"))
                            };
                            products.Add(product);
                        }
                        data.UserProducts[userId] = products;
                    }
                }
            }
            catch
            {
                return new UserData();
            }

            return data;
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

        private int ParseProductId(string stringValue, string numericValue)
        {
            if (!string.IsNullOrWhiteSpace(numericValue) && int.TryParse(numericValue, out var numeric) && numeric > 0)
                return numeric;
            if (int.TryParse(stringValue, out var parsed) && parsed > 0)
                return parsed;
            return 0;
        }

        private Guid ParseGuid(string s)
        {
            return Guid.TryParse(s, out var g) ? g : Guid.NewGuid();
        }

        private DateTime ParseDateTime(string s)
        {
            return DateTime.TryParse(s, out var d) ? d : DateTime.Now;
        }

        private DateTime? ParseNullableDateTime(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s == "null") return null;
            return DateTime.TryParse(s, out var d) ? d : (DateTime?)null;
        }

        private decimal ParseDecimal(string s)
        {
            return decimal.TryParse(s, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out var d) ? d : 0m;
        }

        private int ParseInt(string s)
        {
            return int.TryParse(s, out var i) ? i : 0;
        }

        #endregion
    }
}
