using System;
using System.Collections.Generic;

namespace DevNooTools.Models
{
    [Serializable]
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            Role = "Utilizador";
        }

        public User(string username, string password, string displayName = null)
            : this()
        {
            Username = username;
            PasswordHash = HashPassword(password);
            DisplayName = displayName ?? username;
        }

        public bool ValidatePassword(string password)
        {
            return PasswordHash == HashPassword(password);
        }

        public void SetPassword(string password)
        {
            PasswordHash = HashPassword(password);
        }

        private static string HashPassword(string password)
        {
            // Simple hash for demo purposes - in production use proper hashing like BCrypt
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password + "DevNooToolsSalt");
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }

    [Serializable]
    public class UserData
    {
        public List<User> Users { get; set; } = new List<User>();
        public Dictionary<string, List<Product>> UserProducts { get; set; } = new Dictionary<string, List<Product>>();
    }
}
