using System;
using System.Collections.Generic;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your bank!");
		
        var client1 = new LocalClient(12345,"Janis","Berzins", "Riga");
        var client2 = new ForeignClient(12346, "Biruta", "Ozola", "Lithuania");

		client1.AddAccount(new Account("LV1234567890123", "EUR"));
		client1.AddAccount(new Account("US1234567890124", "USD"));
        client2.AddAccount(new Account("LV1629462790124", "EUR"));
		client2.AddAccount(new Account("US6284510845124", "USD"));
		
		client1.PrintAccounts();
		client2.PrintAccounts();
		
		client1.RequestInfo();
		client2.RequestInfo();
		
        client1.AccountsList[0].Deposit(1200);
        client1.AccountsList[0].Withdraw(30);
        client1.AccountsList[0].Withdraw(50);
        client1.AccountsList[0].Withdraw(3);
        client1.AccountsList[0].Transfer(50, client2.AccountsList[0]);
        client1.AccountsList[0].RequestTransactions();
		client2.AccountsList[0].RequestTransactions();
    }
}
public class Client {
    // definicija
    public static int clientCount = 0;

    private int _id;
    private string _name;
    private string _surname;
	public string Name {
        get {
            return _name;
        }
    }
	public string Surname {
        get {
            return _name;
        }
    }
	public int Id {
        get {
            return _id;
        }
    }
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
    public virtual void RequestInfo() {
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
    private List<Transfer> _transferList = new List<Transfer>();
    private List<Transfer> _recievedTransferList = new List<Transfer>();

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
					Console.WriteLine("Error: invalid length of account number. Must be 15!");
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
        if (amount <= CalculateBalance()) {
            _transactionList.Add(new Transaction(amount, "withdraw"));
        } else {
            Console.WriteLine($"Error: withdrawal of {amount} would put account in negative funds!");
        }
    }
    // transfera sutisanas metode
    public void Transfer(double amount, Account account) {
        // valutu parbaude
        if (this.AccountCurrency == account.AccountCurrency) {
            // naudas pietiekamibas parbaude
            if (amount <= CalculateBalance()) {
                _transferList.Add(new Transfer(amount, account, this));
                account.RecieveTransfer(amount, this);
            } else {
                Console.WriteLine($"Error: transfer of {amount} {this.AccountCurrency} would put account in negative funds!");
            }
        } else {
            Console.WriteLine($"Error: account currencies are different! Transfer cancelled.");
        }
    }
    // transfera sanemsanas metode
    public void RecieveTransfer(double amount, Account account) {
        _recievedTransferList.Add(new Transfer(amount, this, account));
        Console.WriteLine($"A transfer to {AccountNumber} of {amount} has been recieved.");
    }

    // tranzakciju izvada metode
    public void RequestTransactions() {
        Console.WriteLine($"The following transactions have been made on account {AccountNumber}.");
        Console.WriteLine("------------------------------------------------------");
        // tranzakcijas
        foreach (Transaction transaction in _transactionList) {
            Console.WriteLine($"Transaction type: {transaction.TransactionType}. Transaction amount: {transaction.TransactionAmount}. Transaction time: {transaction.TransactionTime}");
        }
        // transferi no konta
        foreach (Transfer transfer in _transferList) {
            Console.WriteLine($"Transfer type: sending funds. Transfer amount: {transfer.Amount}. Transaction time: {transfer.Time}. Recieving account:{transfer.recievingAccountNumber}");
        }
        // transferi uz kontu
        foreach (Transfer transfer in _recievedTransferList) {
            Console.WriteLine($"Transfer type: recieving funds. Transfer amount: {transfer.Amount}. Transaction time: {transfer.Time}. Sending account:{transfer.sendingAccountNumber}");
        }
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"This account has a balance of {CalculateBalance()} {this.AccountCurrency}.\n");
    }

    public double CalculateBalance() {
        double balance = 0;
        // konta tranzakcijas
        foreach (Transaction transaction in _transactionList) {
            if (transaction.TransactionType == "deposit") {
                balance = balance + transaction.TransactionAmount;
            } else {
                balance = balance - transaction.TransactionAmount;
            }
        }
        // transferi no konta
        foreach (Transfer transfer in _transferList) {
            balance = balance - transfer.Amount;
        }
        // transferi uz kontu
        foreach (Transfer transfer in _recievedTransferList) {
            balance = balance + transfer.Amount;
        }
        return balance;
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
	public DateTime TransactionTime {
        get {
            return _transactionTime;
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

public class Transfer {
    //definicija
    private DateTime _time;
    private double _amount;
    private Account _recievingAccount;
    private Account _sendingAccount;

    public double Amount {
        get {
            return _amount;
        }
    }
	public DateTime Time {
        get {
            return _time;
        }
    }
    public string recievingAccountNumber {
        get {
            return _recievingAccount.AccountNumber;
        }
    }
    public string sendingAccountNumber {
        get {
            return _sendingAccount.AccountNumber;
        }
    }
    //konstruktors
    public Transfer(double amount, Account recievingAccount, Account sendingAccount){
        _amount = amount;
        _time = DateTime.Now;
        _recievingAccount = recievingAccount;
        _sendingAccount = sendingAccount;
    }
    //transfera informacijas izvada metode
    public string transferInfo() {
        return ($"At {_time}, a transfer of {_amount} from {_sendingAccount.AccountNumber} to {_recievingAccount.AccountNumber} was made.");
    }
}

// izveido LocalClient klasi kura ir mantots viss no base Client klases (inherit all from Client class)
public class LocalClient : Client {
    // izveido klasei papildus mainigo _city
    private string _city;

    // pievieno konstruktoram izveidoto papildus mainigo
    public LocalClient(int id, string name, string surname, string city) : base(id,name,surname) {
        _city = city;
    }
	// info drukasanas metode
    public override void RequestInfo() {
        Console.WriteLine($"Client ID:{Id} Name:{Name} Surname:{Surname} City:{_city}");
    }
}

// izveido ForeignClient klasi kura ir mantots viss no base Client klases (inherit all from Client class)
public class ForeignClient : Client {
    // izveido klasei papildus mainigo _country
    private string _country;

    // pievieno konstruktoram izveidoto papildus mainigo
    public ForeignClient(int id, string name, string surname, string country) : base(id,name,surname) {
        _country = country;
    }
	   public override void RequestInfo() {
        Console.WriteLine($"Client ID:{Id} Name:{Name} Surname:{Surname} Country:{_country}");
    }
}