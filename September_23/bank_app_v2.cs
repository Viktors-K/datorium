using System;
using System.Collections.Generic;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your bank!");
		
        var client1 = new Client(12345,"Janis","Berzins");
        var client2 = new Client(12346, "Biruta", "Ozola");
        
		var account1 = new Account("LV1234567890123", "EUR");
		var account2 = new Account("US1234567890124", "USD");
		
		client1.AddAccount(account1);
		client1.AddAccount(account2);
    }
}
public class Client {
    public static int clientCount = 0;

    private int _id;
    private string _name;
    private string _surname;

    private List<Account> _accountsList = new List<Account>();

    // konstruktors
    public Client(int id, string name, string surname) {
        _id = id;
        _name = name;
        _surname = surname;
    }

    public void RequestInfo() {
        Console.WriteLine($"Client ID:{_id} Name:{_name} Surname:{_surname}");
    }
	
	public void AddAccount(Account account) {
		_accountsList.Add(account);
	}
}

public class Account {
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