using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
// AutoTesla, a system for renting Teslas.

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
            var controller1 = new CarCtrl("Data Source=main.db", "Cars", creationString1);
			var creationString2 = @"
					CREATE TABLE IF NOT EXISTS Clients (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						Name TEXT NOT NULL,
						Surname TEXT NOT NULL,
						Email TEXT NOT NULL
					);
				";
            var controller2 = new ClientCtrl("Data Source=main.db", "Clients", creationString2);
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
}
public abstract class TableCtrl {
	public string _connectionString;
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
	public List<Dictionary<string, object>> GetAllItemsFromTable() {
		var result = new List<Dictionary<string, object>>();
		using (var connection = new SqliteConnection(_connectionString)) {
			connection.Open();
			var selectCmd = connection.CreateCommand();
			selectCmd.CommandText = $"SELECT * FROM {_infoObjectType}";
			using (var reader = selectCmd.ExecuteReader()) {
				while (reader.Read()) {
					var row = new Dictionary<string, object>();
					for (int i = 0; i < reader.FieldCount; i++) {
						row[reader.GetName(i)] = reader.GetValue(i);
					}
					result.Add(row);
					}
				}
			}
		return result;
    }
	public abstract void AddToTable(params string[] attributes);
	public abstract void AddItem();
	public abstract void PrintItems();
}

public class CarCtrl : TableCtrl {
	public CarCtrl(string connectionString, string infoObjectType, string creationCommand) : base(connectionString, infoObjectType, creationCommand) { }
	public override void AddToTable(params string[] attributes) {
		using (var connection = new SqliteConnection(_connectionString)) {
			connection.Open();
			var insertCmd = connection.CreateCommand();
			insertCmd.CommandText = $"INSERT INTO {_infoObjectType}(Model, HourlyPrice, KmPrice) VALUES (@model, @hourlyPrice, @kmPrice)";
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
		var items = this.GetAllItemsFromTable();
		Console.WriteLine("Car List:");
		foreach (var row in items) {
			Console.WriteLine($"Id: {row["Id"]}, Model: {row["Model"]}, Hourly Price: {row["HourlyPrice"]}, Kilometer Price: {row["KmPrice"]}");
		}
	}
}

public class ClientCtrl : TableCtrl {
	public ClientCtrl(string connectionString, string infoObjectType, string creationCommand) : base(connectionString, infoObjectType, creationCommand) { }
	public override void AddToTable(params string[] attributes) {
		using (var connection = new SqliteConnection(_connectionString)) {
			connection.Open();
			var insertCmd = connection.CreateCommand();
			insertCmd.CommandText = $"INSERT INTO {_infoObjectType}(Name, Surname, Email) VALUES (@name, @surname, @email)";
			insertCmd.Parameters.AddWithValue("@name", attributes[0]);
			insertCmd.Parameters.AddWithValue("@surname", attributes[1]);
			insertCmd.Parameters.AddWithValue("@email", attributes[2]);
			insertCmd.ExecuteNonQuery();
		}
	}
	public override void AddItem() {
		Console.WriteLine("Please enter Client name");
		string clientName = Console.ReadLine();
		Console.WriteLine("Please enter Client surname");
		string clientSurname = Console.ReadLine();
		Console.WriteLine("Please enter Client e-mail");
		string clientEmail = Console.ReadLine();
		this.AddToTable(clientName,clientSurname,clientEmail);
	}
	public override void PrintItems() {
		var items = this.GetAllItemsFromTable();
		Console.WriteLine("Client List:");
		foreach (var row in items) {
			Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Surname: {row["Surname"]}, E-mail: {row["Email"]}");
		}
	}
}