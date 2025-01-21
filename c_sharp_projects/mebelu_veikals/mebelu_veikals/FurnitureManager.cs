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
        public Furniture GetItemFromTable(string name)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                Furniture furniture_item = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM FURNITURE WHERE Name = @name";
                selectCmd.Parameters.AddWithValue("@name", name);
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    furniture_item = new Furniture(
                            name: Convert.ToString(reader["Name"]),
                            price: Convert.ToDouble(reader["Price"]),
                            description: Convert.ToString(reader["Description"]),
                            length: Convert.ToInt32(reader["Length"]),
                            width: Convert.ToInt32(reader["Width"]),
                            height: Convert.ToInt32(reader["Height"])
                        );
                }
                connection.Close();
                return furniture_item;
            }
        }
        public void UpdateItemFromTable(string old_name, Furniture new_furniture)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = @"
					UPDATE Furniture SET
                        Name = @name,
                        Price = @price,
                        Description = @desc,
                        Length = @length,
                        Width = @width,
                        Height = @height
                    WHERE name = @old_name;
				";
                updateCmd.Parameters.AddWithValue("@old_name", old_name);
                updateCmd.Parameters.AddWithValue("@name", new_furniture.Name);
                updateCmd.Parameters.AddWithValue("@price", new_furniture.Price);
                updateCmd.Parameters.AddWithValue("@desc", new_furniture.Description);
                updateCmd.Parameters.AddWithValue("@length", new_furniture.Length);
                updateCmd.Parameters.AddWithValue("@width", new_furniture.Width);
                updateCmd.Parameters.AddWithValue("@height", new_furniture.Height);
                updateCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void RemoveItemFromTable(string name)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = @"
					DELETE FROM Furniture
                    WHERE name = @name;
				";
                updateCmd.Parameters.AddWithValue("@name", name);
                updateCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<String> GetAllRowsFromTable()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                List<String> rows = new List<String>();
                connection.Open();
                var readCmd = connection.CreateCommand();
                readCmd.CommandText = @"SELECT * FROM Furniture;";
                var reader = readCmd.ExecuteReader();
                while (reader.Read())
                {
                    string row = $"{reader["Id"]},{reader["Name"]},{reader["Price"]},{reader["Description"]},{reader["Length"]},{reader["Width"]},{reader["Height"]}";
                    rows.Add(row);
                }
                connection.Close();
                return rows;
            }
        }
        public void AddDataFromCSV(List<String> rows)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                for (int i = 0; i < rows.Count; i++)
                {
                    string[] row_values = rows[i].Split(',');
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = "INSERT INTO Furniture(Name, Price, Description, Length, Width, Height) VALUES (@name, @price, @desc, @length, @width, @height)";
                    insertCmd.Parameters.AddWithValue("@name", row_values[1]);
                    insertCmd.Parameters.AddWithValue("@price", row_values[2]);
                    insertCmd.Parameters.AddWithValue("@desc", row_values[3]);
                    insertCmd.Parameters.AddWithValue("@length", row_values[4]);
                    insertCmd.Parameters.AddWithValue("@width", row_values[5]);
                    insertCmd.Parameters.AddWithValue("@height", row_values[6]);
                    insertCmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}