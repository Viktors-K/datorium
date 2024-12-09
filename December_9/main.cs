using System;
using Microsoft.Data.Sqlite;
using SQLitePCL; // for Batteries.Init()

public class Program
{
    public static void Main()
    {
        // Initialize SQLite provider
        Batteries.Init();
		string connectionString = "Data Source=:memory:";
        // Use an in-memory database for this example
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            
			var createTableCmd = connection.CreateCommand();
			createTableCmd.CommandText = 
				@"CREATE TABLE IF NOT EXISTS Pizzas (
				Id INTEGER PRIMARY KEY AUTOINCREMENT,
				Name TEXT NOT NULL,
				Size TEXT NOT NULL,
				Price REAL NOT NULL
				);";
            
        }
    }
}