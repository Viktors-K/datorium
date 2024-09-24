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
		client2.PrintAccounts();

        client1.AccountsList[0].Deposit(20);
        client1.AccountsList[0].Withdraw(30);
        client1.AccountsList[0].RequestTransactions();
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

    public List<Account> AccountsList {
        get {
            return _accountsList;
        }
    }
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
            Console.WriteLine($"Number: {account.AccountNumber}. ({account.AccountCurrency})");
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
    private List<Transaction> _transactionList = new List<Transaction>();

	public string AccountCurrency {
		get {
			return _accountCurrency;
		}
	}

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

    // deposit tranzakcijas metode
    public void Deposit(double amount) {
        _transactionList.Add(new Transaction(amount, "deposit"));
    }

    // withdraw tranzakcijas metode
    public void Withdraw(double amount) {
        _transactionList.Add(new Transaction(amount, "withdraw"));
    }

    // tranzakciju izvada metode
    public void RequestTransactions() {
        Console.WriteLine($"The following transactions have been made on account {AccountNumber}.");
        foreach (Transaction transaction in _transactionList) {
            Console.WriteLine($"Transaction type: {transaction.TransactionType}. Transaction amount: {transaction.TransactionAmount}.");
        }
    }
}

public class Transaction {
    //definicija
    private DateTime _transactionTime;
    private double _transactionAmount;
    private string _transactionType;

    public string TransactionType {
        get {
            return _transactionType;
        }
    }
    public double TransactionAmount {
        get {
            return _transactionAmount;
        }
    }

    //konstruktors
    public Transaction(double transactionAmount, string transactionType){
        _transactionAmount = transactionAmount;
        _transactionType = transactionType;
        _transactionTime = DateTime.Now;
    }

    //tranzakcijas informacijas izvada metode
    public string transactionInfo() {
        return ($"At {_transactionTime}, a {_transactionType} transaction of {_transactionAmount} was made.");
    }
}