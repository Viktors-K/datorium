using System;
using System.Collections.Generic;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your bank!");
		
        var client1 = new Client(12345,"Janis","Berzins");
        var client2 = new Client(12346, "Biruta", "Ozola");

		client1.AddAccount(new Account("LV1234567890123", "EUR"));
		client1.AddAccount(new Account("US1234567890124", "USD"));
		
		client1.PrintAccounts();
    }
}
public class Client {
    // definicija
    public static int clientCount = 0;

    private int _id;
    private string _name;
    private string _surname;

    // kontu listes definicija
    private List<Account> _accountsList = new List<Account>();

    // konstruktors
    public Client(int id, string name, string surname) {
        _id = id;
        _name = name;
        _surname = surname;
        clientCount++;
    }

    // info drukasanas metode
    public void RequestInfo() {
        Console.WriteLine($"Client ID:{_id} Name:{_name} Surname:{_surname}");
    }
	
    // kontu pievienosanas metode
	public void AddAccount(Account account) {
		_accountsList.Add(account);
	}
    
    // klienta kontu izvada metode 
    public void PrintAccounts() {
        Console.WriteLine($"Client {_name} {_surname} has the following accounts:");
        foreach (Account account in _accountsList) {
            Console.WriteLine($"Number: {account.AccountNumber}.");
        }
    }

    // klientu skaita izvada metode
    public static void RequestClientCount() {
        Console.WriteLine($"There are a total of {clientCount} accounts.");
    }
}

public class Account {
    // definicija
    private string _accountNumber;
    private string _accountCurrency;

    // accountNumber parbaude
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

    // konstruktors
    public Account(string accountNumber, string accountCurrency){
        AccountNumber = accountNumber;
        _accountCurrency = accountCurrency;
    }
}