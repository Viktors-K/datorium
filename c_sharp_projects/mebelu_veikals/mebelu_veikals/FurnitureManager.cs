using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;

namespace mebelu_veikals
{
    public class FurnitureManager
    {
        private readonly string _connectionString;
        public FurnitureManager(string connectionString)
        {
            _connectionString = connectionString;
            CreateItemTable();
        }
        private void CreateItemTable()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
					CREATE TABLE IF NOT EXISTS Furniture (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						Name TEXT NOT NULL UNIQUE,
						Price REAL NOT NULL,
                        Description TEXT NOT NULL, 
                        Length INTEGER NOT NULL, 
                        Width INTEGER NOT NULL, 
                        Height INTEGER NOT NULL
					);
				";
                createTableCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void AddItemToTable(Furniture item)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Furniture(Name, Price, Description, Length, Width, Height) VALUES (@name, @price, @desc, @length, @width, @height)";
                insertCmd.Parameters.AddWithValue("@name", item.Name);
                insertCmd.Parameters.AddWithValue("@price", item.Price);
                insertCmd.Parameters.AddWithValue("@desc", item.Description);
                insertCmd.Parameters.AddWithValue("@length", item.Length);
                insertCmd.Parameters.AddWithValue("@width", item.Width);
                insertCmd.Parameters.AddWithValue("@height", item.Height);
                insertCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<Furniture> GetAllItemsFromTable()
        {
            List<Furniture> items = new List<Furniture>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM FURNITURE";
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(
                        new Furniture(
                            name: Convert.ToString(reader["Name"]), 
                            price:Convert.ToDouble(reader["Price"]),
                            description: Convert.ToString(reader["Description"]),
                            length: Convert.ToInt32(reader["Length"]),
                            width: Convert.ToInt32(reader["Width"]),
                            height: Convert.ToInt32(reader["Height"])
                        )
                    );
                }
                connection.Close();
                return items;
            }
        }
    }
}