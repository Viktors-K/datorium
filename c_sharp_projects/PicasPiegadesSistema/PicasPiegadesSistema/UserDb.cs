using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace PicasPiegadesSistema
{
    class UserDb
    {
        private readonly string _connectionString;
        public UserDb(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void CreateUserTable()
        {
            using (var connection = new SqliteConnection(this._connectionString))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        PasswordHash TEXT NOT NULL
                    )
                   ";
                createTableCmd.ExecuteNonQuery();
            }
        }
        public void CreateUser(string username, string password)
        {
            using (var connection = new SqliteConnection(this._connectionString))
            {
                connection.Open();
                var createUserCmd = connection.CreateCommand();
                createUserCmd.CommandText = @"
                    INSERT INTO Users(Username, Password)
                    VALUES (@username, @password)
                    )
                   ";
                //createUserCmd.ExecuteNonQuery();
            }
        }
    }
}
