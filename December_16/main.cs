using System;
using Microsoft.Data.Sqlite;

class Program {
    static void Main(string[] args) {
        try {
			var creationString1 = @"
					CREATE TABLE IF NOT EXISTS Cars (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						Model TEXT NOT NULL,
						HourlyPrice REAL NOT NULL,
						KmPrice REAL NOT NULL
					);
				";
            var controller1 = new CarCtrl("Data Source=cars.db", "Cars", creationString1);
			while (true) {
				Console.WriteLine("Choose option: 'add', 'print' or 'stop'.");
				var userCommand = Console.ReadLine();
				switch (userCommand) {
					case "add":
						controller1.AddItem();
						break;
					case "print":
						controller1.PrintItems();
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

public abstract class TableCtrl {
	private string _connectionString;
	public string _infoObjectType;
	public TableCtrl(string connectionString, string infoObjectType, string creationCommand) {
		_connectionString = connectionString;
		_infoObjectType = infoObjectType;
		CreateTable(creationCommand);
	} 
	private void CreateTable(string creationCommand) {
		using (var connection = new SqliteConnection(_connectionString)) {
			connection.Open();
			var createTableCmd = connection.CreateCommand();
			createTableCmd.CommandText = creationCommand;
			createTableCmd.ExecuteNonQuery();
			Console.WriteLine("Table created or already exists.");
		}
	}
	public SqliteDataReader GetAllItemsFromTable() {
		using (var connection = new SqliteConnection(_connectionString)) {
			var selectCmd = connection.CreateCommand();
			selectCmd.CommandText = "SELECT * FROM {_infoObjectType}";
			return selectCmd.ExecuteReader();
		}
	}
	public abstract void AddToTable(params string[] attributes);
	public abstract void AddItem();
	public abstract void PrintItems();
}

public class CarCtrl : TableCtrl {
	private string _connectionString;
	public CarCtrl(string connectionString, string infoObjectType, string creationCommand) : base(connectionString, infoObjectType, creationCommand) { }
	public override void AddToTable(params string[] attributes) {
		using (var connection = new SqliteConnection(_connectionString)) {
			connection.Open();
			var insertCmd = connection.CreateCommand();
			insertCmd.CommandText = $"INSERT INTO {_infoObjectType}(Model, HourlyPrice, KmPrice) VALUES (@model, @hourlyPrice, @kmPrice)";
			Console.WriteLine(insertCmd.CommandText);
			insertCmd.Parameters.AddWithValue("@model", attributes[0]);
			insertCmd.Parameters.AddWithValue("@hourlyPrice", Convert.ToDouble(attributes[1]));
			insertCmd.Parameters.AddWithValue("@kmPrice", Convert.ToDouble(attributes[2]));
			insertCmd.ExecuteNonQuery();
		}
	}
	public override void AddItem() {
		Console.WriteLine("Please enter Car model");
		string carModel = Console.ReadLine();
		Console.WriteLine("Please enter Car hourly price");
		string carHourlyPrice = Console.ReadLine();
		Console.WriteLine("Please enter Car km price");
		string carKmPrice = Console.ReadLine();
		this.AddToTable(carModel,carKmPrice,carKmPrice);
	}
	public override void PrintItems() {
		using (var reader = this.GetAllItemsFromTable()) {
			Console.WriteLine("Car List:");
			while(reader.Read()) {
				Console.WriteLine($"Id: {reader["Id"]}, Model: {reader["Model"]}, Hourly Price: {reader["HourlyPrice"]}, Kilometer Price: {reader["KmPrice"]}");
			}
		}	
	}
}}