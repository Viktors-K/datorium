using System;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to your bank!");
    }
}
public class Client {
    public int id;
    public string name;
    public string surname;
    public string accountNumber;
    
    public void RequestInfo() {
        Console.WriteLine($"{id}{name}{surname}{accountNumber}")
    }
}
