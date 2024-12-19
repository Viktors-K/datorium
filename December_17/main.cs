using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
namespace TeslaRentalPlatform {
    public class Car {
        public int ID { get; set; }
        public string Model { get; set; }
        public double HourlyRate { get; set; }
        public double PerKmRate { get; set; }
    }
    public class Client {
        public int ID { get; set; }
        public string Name { get; set; }
		public string Surname { get; set; }
        public string Email { get; set; }
    }
	public class Rental {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double DistanceKm { get; set; }
        public double TotalPayment { get; set; }
    }
	
    class Program {
		private static List<Car> carList = new List<Car>();
        private static List<Car> carReader(SqliteConnection connection) {
			var carList = new List<Car>();
			var selectCmd = connection.CreateCommand();
			selectCmd.CommandText = $"SELECT * FROM Cars";
			using (var reader = selectCmd.ExecuteReader()) {
				while (reader.Read()) {
					var newCar = new Car();
					for (int i = 0; i < reader.FieldCount; i++) {
						var property = typeof(Car).GetProperty(reader.GetName(i));
                    	property.SetValue(newCar, Convert.ChangeType(reader.GetValue(i), property.PropertyType));
					}
					carList.Add(newCar);
				}
			}
			return carList;
		}
		private static void CreateTables(SqliteConnection connection) {
			var createTableCmd = connection.CreateCommand();
			createTableCmd.CommandText =@"
				CREATE TABLE IF NOT EXISTS Cars (
					Id INTEGER PRIMARY KEY AUTOINCREMENT,
					Model TEXT NOT NULL,
					HourlyRate REAL NOT NULL,
					PerKmPrice REAL NOT NULL
				);";
			createTableCmd.ExecuteNonQuery();
			createTableCmd.CommandText =@"
				CREATE TABLE IF NOT EXISTS Clients (
					Id INTEGER PRIMARY KEY AUTOINCREMENT,
					Name TEXT NOT NULL,
					Surname TEXT NOT NULL,
					Email TEXT NOT NULL
				);";
			createTableCmd.ExecuteNonQuery();
			createTableCmd.CommandText =@"
				CREATE TABLE IF NOT EXISTS Rentals (
					Id INTEGER PRIMARY KEY AUTOINCREMENT,
					ClientId INTEGER NOT NULL,
					CarId INTEGER NOT NULL,
					StartTime DATETIME NOT NULL,
					EndTime DATETIME NOT NULL,
					DistanceKm DECIMAL NOT NULL,
					TotalPayment DECIMAL NOT NULL,
					FOREIGN KEY (ClientId) REFERENCES Clients(Id),
					FOREIGN KEY (CarId) REFERENCES Cars(Id)
				);";
			createTableCmd.ExecuteNonQuery();
			Console.WriteLine("Tables created or already existing.");
		}
        static void AddCar(SqliteConnection connection, string model, double hourlyRate, double perKmRate) {
			
        }
        static void RegisterClient() {
			
        }
        static void RentCar(Client client, Car car, DateTime startTime, DateTime endTime, double distanceKm) {
			
        }
        static void CalculatePayment(int rentalId) {
			
        }
		static void Main(string[] args) {
			using (var connection = new SqliteConnection("Data Source=main.db")) {
				connection.Open();
				CreateTables(connection);
				carList = carReader(connection);
				foreach (var car in carList) {
        			Console.WriteLine($"ID: {car.ID}, Model: {car.Model}, Hourly Rate: {car.HourlyRate}, Per Km Rate: {car.PerKmRate}");
			    }
			}
        }
    }
}