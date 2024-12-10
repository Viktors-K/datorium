using Microsoft.Data.Sqlite;
using System;

class Program {
    static void Main(string[] args) {
        string connectionString = "Data Source=pizza_store.db";
        try
        {
            var controller1 = new PizzaCtrl(connectionString);
			while (true) {
				Console.WriteLine("Choose option: 'add', 'print' or 'stop'.");
				var userCommand = Console.ReadLine();
				switch (userCommand) {
					case "add":
						controller1.AddPizza();
						break;
					case "print":
						controller1.PrintPizzas();
						break;
					case "stop":
						return;
					default:
						Console.WriteLine("Invalid option.");
						break;
				}
			}
        }
        catch (Exception ex) {
            Console.WriteLine(ex);
        }
    }
	
	
	public class PizzaCtrl {
		private string _connectionString;
		public PizzaCtrl(string connectionString) {
			_connectionString = connectionString;
			CreatePizzaTable();
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
		public void AddPizza() {
			Console.WriteLine("Please enter Pizza name");
			string pizzaName = Console.ReadLine();
			Console.WriteLine("Please enter Pizza size");
			string pizzaSize = Console.ReadLine();
			Console.WriteLine("Please enter Pizza price");
			double pizzaPrice = Convert.ToDouble(Console.ReadLine());
			this.AddPizzaToTable(pizzaName,pizzaSize,pizzaPrice);
		}
		public void PrintPizzas() {
			using (var reader = this.GetAllPizzasFromTable()) {
				Console.WriteLine("Pizza List:");
				while(reader.Read()) {
					Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Size: {reader["Size"]}");
				}
			}	
		}
	}
}
