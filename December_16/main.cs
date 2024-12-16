using System;
using Microsoft.Data.Sqlite;

public class Program {
	public static void Main() {
		
		Console.WriteLine("Hello World");
	}
}

public abstract class TableCtrl {
	private string _connectionString;
	private string _infoObjectType;
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
			insertCmd.CommandText = "INSERT INTO Cars(Model, HourlyPrice, KmPrice) VALUES (@model, @hourlyPrice, @kmPrice)";
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
}