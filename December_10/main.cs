using Microsoft.Data.Sqlite;
using Microsoft.Data.SqlClient;
using System;

class Program {
    static void Main(string[] args) {
        // Connection string for SQLite
        string connectionString = "Data Source=pizza_store.db";
        try
        {
            // Create and open the SQLite connection
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // Create table if it doesn't exist
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Pizzas (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Size TEXT NOT NULL,
                        Price REAL NOT NULL
                    );
                ";
                createTableCmd.ExecuteNonQuery();
                Console.WriteLine("Table created or already exists.");
                
                //Promt user for pizza name
                Console.WriteLine("Please enter Pizza name");
                string pizzaName = Console.ReadLine();
                
                //Promt user for pizza size
                Console.WriteLine("Please enter Pizza size");
                string pizzaSize = Console.ReadLine();
                
                //Promt user for pizza price
                Console.WriteLine("Please enter Pizza price");
                double pizzaPrice = Convert.ToDouble(Console.ReadLine());
				
				// Insert data in SQL lite database
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Pizzas(Name, Size, Price) VALUES (@name, @size, @price)";
                insertCmd.Parameters.AddWithValue("@name", pizzaName);
                insertCmd.Parameters.AddWithValue("@size", pizzaSize);
                insertCmd.Parameters.AddWithValue("@price", pizzaPrice);
                
                insertCmd.ExecuteNonQuery();
                Console.WriteLine("PIZZA IS ADDED TO DATABASE");
                
                // Query to display pizza database elements
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM PIZZAS";
                
                using (var reader = selectCmd.ExecuteReader()) {
                    Console.WriteLine("Pizza List:");
                    while(reader.Read()) {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Size: {reader["Size"]}");
                    }
                }
            }
        }
        catch (Exception ex) {
            Console.WriteLine("Test");
        }
    }
	
	
	public class PizzaCtrl {
		private string _connectionString;
		public PizzaCtrl(string connectionString) {
			_connectionString = connectionString;
			}
		private void CreatePizzaTable() {
			using (var connection = new SqliteConnection(_connectionString)) {
				connection.Open();

				var createTableCmd = connection.CreateCommand();
				createTableCmd.CommandText = @"
					CREATE TABLE IF NOT EXISTS Pizzas (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						Name TEXT NOT NULL,
						Size TEXT NOT NULL,
						Price REAL NOT NULL
					);
				";
				createTableCmd.ExecuteNonQuery();
				Console.WriteLine("Table created or already exists.");
			}
		}
		private void AddPizzaToTable(string name, string size, Double price) {
			using (var connection = new SqliteConnection(_connectionString)) {
				connection.Open();
				
				var insertCmd = connection.CreateCommand();
				insertCmd.CommandText = "INSERT INTO Pizzas(Name, Size, Price) VALUES (@name, @size, @price)";
				insertCmd.Parameters.AddWithValue("@name", name);
				insertCmd.Parameters.AddWithValue("@size", size);
				insertCmd.Parameters.AddWithValue("@price", price);
			
				insertCmd.ExecuteNonQuery();
			}
		}
		private SqliteDataReader GetAllPizzasFromTable() {
			using (var connection = new SqliteConnection(_connectionString)) {
				var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM PIZZAS";
				return selectCmd.ExecuteReader();
			}
		}
	}
}
