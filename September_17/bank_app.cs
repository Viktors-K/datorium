using System;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to your bank!");
        var client1 = new Client(12345,"Jānis","Bērziņš","LV198198198");
        client1.RequestInfo();
        Client.Greetings();
    }
}
public class Client {
    public static int clientCount = 0;

    private int _id;
    private string _name;
    private string _surname;
    private string _accountNumber;
    
    // konstruktors
    public Client(int id, string name, string surname, string accountNumber) {
        _id = id;
        _name = name;
        _surname = surname;
        _accountNumber = accountNumber;
    }

    public void RequestInfo() {
        Console.WriteLine($"{_id} {_name} {_surname} {_accountNumber}");
    }

    public static void Greetings() {
        Console.WriteLine("Hello, I am a Client Class!");
    }
}
