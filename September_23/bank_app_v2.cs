using System;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to your bank!");
        var client1 = new Client(12345,"Janis","Berzins");
        var client2 = new Client(12346, "Biruta", "Ozola");
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
    public Client(int id, string name, string surname) {
        _id = id;
        _name = name;
        _surname = surname;
    }

    public void RequestInfo() {
        Console.WriteLine($"{_id} {_name} {_surname}");
    }

    public static void Greetings() {
        Console.WriteLine("Hello, I am a Client Class!");
    }
}

class Account {
    private string _accountNumber;
    private string _accountCurrency;

    public string AccountNumber {
        get {
            return _accountNumber;
        }

        set {
            if (string.IsNullOrEmpty(value)) {
                Console.WriteLine("Error: cannot assign empty value!");
            } else {
				if (value.Length != 15) {
					Console.WriteLine("Error: invalid length of account number!");
				} else {
					_accountNumber = value;
				}
                
            }
        }
    }

    public Account(string accountNumber, string accountCurrency){
        AccountNumber = accountNumber;
        _accountCurrency = accountCurrency;
    }
}