using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace DevNooTools
{
    public class DatabaseHelper
    {
        private readonly string baseUrl;
        private readonly string anonKey;
        private readonly HttpClient httpClient;
        private readonly string dbPath;

        public DatabaseHelper(string baseUrl = null, string anonKey = null)
        {
            this.baseUrl = string.IsNullOrWhiteSpace(baseUrl) ? "https://pnvalhgbvzccqtuncgqb.supabase.co" : baseUrl.Trim().TrimEnd('/');
            this.anonKey = string.IsNullOrWhiteSpace(anonKey) ? "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBudmFsaGdidnpjY3F0dW5jZ3FiIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjQ4NDQyMDIsImV4cCI6MjA4MDQyMDIwMn0.HjAs1cnvOf-ojlabNjv7Sxfmngn77BoMYNCxsH8VIx4" : anonKey;

            dbPath = this.baseUrl;

            httpClient = new HttpClient { BaseAddress = new Uri(this.baseUrl) };
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.anonKey);
            httpClient.DefaultRequestHeaders.Add("apikey", this.anonKey);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public string DatabasePath => dbPath;

        public List<Product> LoadProducts()
        {
            try
            {
                var res = httpClient.GetAsync("/rest/v1/products?select=id,name,description,price,quantity").Result;
                if (!res.IsSuccessStatusCode)
                    return new List<Product>();

                var json = res.Content.ReadAsStringAsync().Result;
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
                // Use upsert: POST with on_conflict=id and Prefer resolution=merge-duplicates
                var json = SerializeProductsToJson(products);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Build request uri with on_conflict
                string uri = "/rest/v1/products?on_conflict=id&return=representation";
                var postReq = new HttpRequestMessage(HttpMethod.Post, uri) { Content = content };
                postReq.Headers.Add("Prefer", "resolution=merge-duplicates,return=representation");

                var postRes = httpClient.SendAsync(postReq).Result;
                if (!postRes.IsSuccessStatusCode)
                {
                    var txt = postRes.Content.ReadAsStringAsync().Result;
                    throw new Exception($"Supabase save failed: {postRes.StatusCode} - {txt}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar dados na Supabase: {ex.Message}", ex);
            }
        }

        // New: test connection by requesting a small select
        public (bool Success, string Message) TestConnection()
        {
            try
            {
                var res = httpClient.GetAsync("/rest/v1/products?select=id&limit=1").Result;
                var body = res.Content.ReadAsStringAsync().Result;
                if (res.IsSuccessStatusCode)
                    return (true, $"OK ({res.StatusCode}) - {body}");
                return (false, $"{res.StatusCode} - {body}");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
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
            sb.Append('[');
            bool first = true;
            foreach (var p in products)
            {
                if (!first) sb.Append(',');
                first = false;
                sb.Append('{');
                sb.AppendFormat("\"id\": \"{0}\",", p.Id.ToString());
                sb.AppendFormat("\"name\": \"{0}\",", EscapeJsonString(p.Name));
                sb.AppendFormat("\"description\": \"{0}\",", EscapeJsonString(p.Description));
                sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, "\"price\": {0},", p.Price);
                sb.AppendFormat("\"quantity\": {0}", p.Quantity);
                sb.Append('}');
            }
            sb.Append(']');
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
