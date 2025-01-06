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
        static void Main(string[] args) {
			
        }
        static void AddCar(string model, double hourlyRate, double perKmRate) {
			
        }
        static void RegisterClient(string name, string surname, string email) {
			
        }
        static void RentCar(int clientId, int carId, DateTime startTime, DateTime endTime, double distanceKm) {
			
        }
        static void CalculatePayment(int rentalId) {
			
        }
    }
}