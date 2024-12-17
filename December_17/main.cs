using System;
using Microsoft.Data.Sqlite;

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
        private void CreateTables(SqliteConnection connection) {
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
					TotalPayment DECIMAL NOT NULL
				);";
			createTableCmd.ExecuteNonQuery();
			Console.WriteLine("Tables created or already existing.");
		}
        static void AddCar(string model, double hourlyRate, double perKmRate) {
			
        }
        static void RegisterClient(string name, string surname, string email) {
			
        }
        static void RentCar(int clientId, int carId, DateTime startTime, DateTime endTime, double distanceKm) {
			
        }
        static void CalculatePayment(int rentalId) {
			
        }
		static void Main(string[] args) {
			var connection = new SqliteConnection("Data Source=main.db");
			connection.Open();
			CreateTables(connection);
        }
    }
}