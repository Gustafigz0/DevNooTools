using System;
using System.Data.SQLite;
using System.IO;

namespace DevNooTools
{
    public class DatabaseHelper
    {
        private readonly string connectionString;
        private readonly string dbPath;

        public DatabaseHelper(string dbFileName = "devnootools.db")
        {
            dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbFileName);
            connectionString = $"Data Source={dbPath};Version=3;";
            InitializeDatabase();
        }

        public string ConnectionString => connectionString;
        public string DatabasePath => dbPath;

        private void InitializeDatabase()
        {
            bool isNewDatabase = !File.Exists(dbPath);

            if (isNewDatabase)
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Products (
                        Id TEXT PRIMARY KEY,
                        Name TEXT NOT NULL,
                        Description TEXT,
                        Price REAL NOT NULL,
                        Quantity INTEGER NOT NULL
                    );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
