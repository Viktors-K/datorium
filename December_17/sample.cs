using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TeslaRentalPlatform
{
    // Entity classes representing the database tables
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public double HourlyRate { get; set; }
        public double PerKmRate { get; set; }
    }

    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Rental
    {
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

    // DbContext class to manage the database
    public class TeslaRentalContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tesla_rental.db");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TeslaRentalContext())
            {
                db.Database.EnsureCreated();

                // Add initial data
                if (!db.Cars.Any()) AddCar(db, "Model 3", 10, 0.5);
                if (!db.Clients.Any()) RegisterClient(db, "John Doe", "john@example.com");

                // Process rental
                RentCar(db, 1, 1, DateTime.Now, DateTime.Now.AddHours(3), 150);
                CalculatePayment(db, 1);
            }
        }

        static void AddCar(TeslaRentalContext db, string model, double hourlyRate, double perKmRate)
        {
            db.Cars.Add(new Car { Model = model, HourlyRate = hourlyRate, PerKmRate = perKmRate });
            db.SaveChanges();
            Console.WriteLine($"Car '{model}' added successfully.");
        }

        static void RegisterClient(TeslaRentalContext db, string name, string email)
        {
            db.Clients.Add(new Client { Name = name, Email = email });
            db.SaveChanges();
            Console.WriteLine($"Client '{name}' registered successfully.");
        }

        static void RentCar(TeslaRentalContext db, int clientId, int carId, DateTime startTime, DateTime endTime, double distanceKm)
        {
            var car = db.Cars.Find(carId);
            if (car == null) return;

            double hours = (endTime - startTime).TotalHours;
            double totalPayment = (hours * car.HourlyRate) + (distanceKm * car.PerKmRate);

            db.Rentals.Add(new Rental
            {
                ClientID = clientId,
                CarID = carId,
                StartTime = startTime,
                EndTime = endTime,
                DistanceKm = distanceKm,
                TotalPayment = totalPayment
            });

            db.SaveChanges();
            Console.WriteLine("Rental recorded successfully.");
        }

        static void CalculatePayment(TeslaRentalContext db, int rentalId)
        {
            var rental = db.Rentals
                .Include(r => r.Client)
                .Include(r => r.Car)
                .FirstOrDefault(r => r.ID == rentalId);

            if (rental != null)
            {
                Console.WriteLine($"Client: {rental.Client.Name}");
                Console.WriteLine($"Car: {rental.Car.Model}");
                Console.WriteLine($"Total Payment: EUR {rental.TotalPayment:F2}");
            }
        }
    }
}
