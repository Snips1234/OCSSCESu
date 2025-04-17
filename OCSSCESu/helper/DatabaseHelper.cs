using MySql.Data.MySqlClient;
using OCSSCESu.Properties;
using System;

namespace OCSSCESu.Helper
{
    public class DatabaseHelper
    {

        public static MySqlConnection DatabaseConnection()
        {
            var port = Settings.Default.port;
            var server = Settings.Default.server;
            var username = Settings.Default.username;
            var password = Settings.Default.password;
            var databaseName = Settings.Default.database;

            string connectionString = $"server={server}; user={username}; password={password}; database={databaseName}; port={port};";
            try
            {

                var connection = new MySqlConnection(connectionString);
                connection.Open();

                return connection;

            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
