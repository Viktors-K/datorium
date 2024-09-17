using System;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to your bank!");
        var client1 = new Client();
        client1.id = 12345;
        client1.name = "Jānis";
        client1.surname = "Bērziņš";
        client1.accountNumber = "LV198198198";
        client1.RequestInfo();
        Client.Greetings();
    }
}
public class Client {
    public static int clientCount = 0;

    public int id;
    public string name;
    public string surname;
    public string accountNumber;
    
    public void RequestInfo() {
        Console.WriteLine($"{id} {name} {surname} {accountNumber}");
    }

    public static void Greetings() {
        Console.WriteLine("Hello, I am a Client Class!");
    }
}
