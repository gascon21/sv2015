// Chen Chao
// 28-01-2016

using System;

public class Transaction
{
    protected byte day;
    protected byte month;
    protected ushort year;
    protected double amount;
    protected string description;
    
    public Transaction(byte day, byte month, ushort year, double amount,
            string description)
    {
        this.day = day;
        this.month = month;
        this.year = year;
        this.amount = amount;
        this.description = description;
    }
    
    public byte GetDay()
    {
        return day;
    }
    
    public byte GetMonth()
    {
        return month;
    }
    
    public ushort GetYear()
    {
        return year;
    }
    
    public double GetAmount()
    {
        return amount;
    }
    
    public string GetDescription()
    {
        return description;
    }
}

public class TransactionList
{
    protected Transaction[] transaction;
    
    public void Add(Transaction newtransaction)
    {
        int count = GetLength() + 1;
        
        Transaction[] tempTransaction = new Transaction[count];
        
        for (int i = 0; i < GetLength(); i++)
        {
            tempTransaction[i] = transaction[i];
        }
        tempTransaction[count-1] = newtransaction;
        
        transaction = tempTransaction;
    }
    
    public int GetLength()
    {
        if (transaction == null)
            return 0;
        return transaction.Length;
    }
    
    public Transaction GetTransaction(int index)
    {
        return transaction[index];
    }
}

public class RepetitiveTransaction
{
    protected byte day;
    protected byte month;
    protected double expectedAmount;
    protected string description;
    
    public RepetitiveTransaction(byte day, byte month, double expectedAmount,
            string description)
    {
        this.day = day;
        this.month = month;
        this.expectedAmount = expectedAmount;
        this.description = description;
    }
    
    public byte GetDay()
    {
        return day;
    }
    
    public byte GetMonth()
    {
        return month;
    }
    
    public double GetExpectedAmount()
    {
        return expectedAmount;
    }
    
    public string GetDescription()
    {
        return description;
    }
}

public class RepetitiveTransactionList
{
    protected RepetitiveTransaction[] repetitiveTransaction;
    
    public void Add(RepetitiveTransaction newRepetitiveTransaction)
    {
        int count = GetLength() + 1;
        
        RepetitiveTransaction[] tempTransaction = 
            new RepetitiveTransaction[count];
        
        for (int i = 0; i < GetLength(); i++)
        {
            tempTransaction[i] = repetitiveTransaction[i];
        }
        tempTransaction[count-1] = newRepetitiveTransaction;
        
        repetitiveTransaction = tempTransaction;
    }
    
    public int GetLength()
    {
        if (repetitiveTransaction == null)
            return 0;
        return repetitiveTransaction.Length;
    }
    
    public RepetitiveTransaction GetRepetitiveTransaction(int index)
    {
        return repetitiveTransaction[index];
    }
}

public class HomeAccounting
{
    TransactionList transactionList = new TransactionList();
    RepetitiveTransactionList repetitiveTransactionList =
        new RepetitiveTransactionList();
    
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Add transaction");
        Console.WriteLine("2. Add repetitive transaction");
        Console.WriteLine("3. Show transactions");
        Console.WriteLine("4. Show repetitive transactions");
        Console.WriteLine("5. Find transactions");
        Console.WriteLine("0. Exit");
    }
    
    public char GetOption()
    {
        return Console.ReadKey().KeyChar;
    }
    
    public void PressKey()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    
    public void ShowTransactions()
    {
        Console.WriteLine();
        
        if (transactionList.GetLength() > 0)
        {
            string text;
            
            do
            {
                Console.Write("Enter the year of the transaction: ");
                text = Console.ReadLine();
                
                if (! IsValidNumber(text))
                    Console.WriteLine("The year is not valid.");
            }
            while (! IsValidNumber(text));
                
            ushort year = Convert.ToUInt16(text);
            
            do
            {
                Console.Write("Enter the month of the transaction: ");
                text = Console.ReadLine();
                
                if (! IsValidMonth(text))
                    Console.WriteLine("The month is not valid.");
            }
            while (! IsValidMonth(text));
            
            byte month = Convert.ToByte(text);
            bool transactionFound = false;
            
            for (int i = 0; i < transactionList.GetLength(); i++)
            {
                if (transactionList.GetTransaction(i).GetMonth() == month &&
                        transactionList.GetTransaction(i).GetYear() == year)
                {
                    Console.WriteLine("Transaction - Day: " + 
                        transactionList.GetTransaction(i).GetDay() + 
                        " Month: " +
                        transactionList.GetTransaction(i).GetMonth() + 
                        " Year: " +
                        transactionList.GetTransaction(i).GetYear() + 
                        " Amount: " +
                        transactionList.GetTransaction(i).GetAmount() + 
                        " Description: " + 
                        transactionList.GetTransaction(i).GetDescription());
                        
                    transactionFound = true;
                }
            }
            
            if (! transactionFound)
            Console.WriteLine("No transactions registered at the month and " +
                "year you entered.");
        }
        else
            Console.WriteLine("No transactions registered.");
    }
    
    public void ShowRepetitiveTransactions()
    {
        Console.WriteLine();
        
        if (repetitiveTransactionList.GetLength() > 0)
        {
            string text;
            
            do
            {
                Console.Write("Enter the month of the transactions: ");
                text = Console.ReadLine();
                
                if (! IsValidMonth(text))
                    Console.WriteLine("The month is not valid.");
            }
            while (! IsValidMonth(text));
            
            byte month = Convert.ToByte(text);
            bool transactionFound = false;
            
            for (int i = 0; i < repetitiveTransactionList.GetLength(); i++)
            {
                if (repetitiveTransactionList.GetRepetitiveTransaction(i).
                        GetMonth() == month)
                {
                    Console.WriteLine("Repetitive transaction - Day: " +
                        repetitiveTransactionList.GetRepetitiveTransaction(i)
                        .GetDay() + " Month: " + 
                        repetitiveTransactionList.GetRepetitiveTransaction(i)
                        .GetMonth() + " Amount: " + 
                        repetitiveTransactionList.GetRepetitiveTransaction(i)
                        .GetExpectedAmount() + " Description: " +
                        repetitiveTransactionList.GetRepetitiveTransaction(i)
                        .GetDescription());
                
                    transactionFound = true;
                }
            }
            
            if (! transactionFound)
            Console.WriteLine("No transactions registered at the month " +
                "you entered.");
        }
        else
            Console.WriteLine("No transactions registered.");
    }
    
    public void FindTransactions()
    {
        Console.WriteLine();
        
        if (transactionList.GetLength() > 0 || 
                repetitiveTransactionList.GetLength() > 0)
        {
            Console.Write(
                "Enter information about the transaction to find: ");
            string text = Console.ReadLine();
            
            bool transactionFound = false;
            
            if (text != "")
            {
                for (int i = 0; i < transactionList.GetLength(); i++)
                {
                    if (transactionList.GetTransaction(i).GetDescription()
                            .Contains(text))
                    {
                        Console.WriteLine("Transaction - Day: " + 
                            transactionList.GetTransaction(i).GetDay() + 
                            " Month: " +
                            transactionList.GetTransaction(i).GetMonth() + 
                            " Year: " +
                            transactionList.GetTransaction(i).GetYear() + 
                            " Amount: " +
                            transactionList.GetTransaction(i).GetAmount() + 
                            " Description: " + 
                            transactionList.GetTransaction(i).GetDescription());
                            
                        transactionFound = true;
                    }
                }
                
                for (int i = 0; i < repetitiveTransactionList.GetLength(); i++)
                {
                    if (repetitiveTransactionList.GetRepetitiveTransaction(i)
                            .GetDescription().Contains(text))
                    {
                        Console.WriteLine("Repetitive transaction - Day: " +
                            repetitiveTransactionList.GetRepetitiveTransaction(i)
                            .GetDay() + " Month: " + 
                            repetitiveTransactionList.GetRepetitiveTransaction(i)
                            .GetMonth() + " Amount: " + 
                            repetitiveTransactionList.GetRepetitiveTransaction(i)
                                .GetExpectedAmount()
                            + " Description: " +
                            repetitiveTransactionList.GetRepetitiveTransaction(i)
                                .GetDescription());
                            
                        transactionFound = true;
                    }
                }
            }
            if (! transactionFound)
            Console.WriteLine("No transaction contains the information you " +
                "entered.");
        }
        else
            Console.WriteLine("No transactions registered.");
    }
    
    public bool IsValidNumber(string number)
    {
        try
        {
            Convert.ToDouble(number);
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public bool IsValidMonth(string month)
    {
        byte newMonth;
        
        if (IsValidNumber(month) && (month.Length <= 2 && month.Length > 0))
        {
            newMonth = Convert.ToByte(month);
            
            if (newMonth > 0 && newMonth <= 12)
                return true;
        }
        return false;
    }
    
    public bool IsValidDay(string day, byte month)
    {
        byte newDay;
        
        if (IsValidNumber(day) && (day.Length <= 2 && day.Length > 0))
        {
            newDay = Convert.ToByte(day);
            
            if (month == 2 && (newDay > 0 && newDay <= 28))
                return true;
                
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && 
                    (newDay > 0 && newDay <= 30))
                return true;
                
            else if (newDay > 0 && newDay <= 31)
                return true;
        }
        
        return false;
    }
    
    public void AddTransaction()
    {
        string text;
        Console.WriteLine();
        
        do
        {
            Console.Write("Enter the year of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidNumber(text))
                Console.WriteLine("Year not valid.");
        }
        while (! IsValidNumber(text));
            
        ushort year = Convert.ToUInt16(text);

        
        do
        {
            Console.Write("Enter the month of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidMonth(text))
                Console.WriteLine("Month not valid.");
        }
        while (! IsValidMonth(text));
        
        byte month = Convert.ToByte(text);
        
        do
        {
            Console.Write("Enter the day of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidDay(text, month))
                Console.WriteLine("Day not valid.");
        }
        while (! IsValidDay(text, month));
        
        byte day = Convert.ToByte(text);
        
        do
        {
            Console.Write("Enter the amount of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidNumber(text))
                Console.WriteLine("Not valid amount.");
        }
        while (! IsValidNumber(text));
        
        double amount = Convert.ToDouble(text);
        string description;
        
        do
        {
            Console.Write("Enter the description of the transaction: ");
            description = Console.ReadLine();
            
            if (description == "")
                Console.WriteLine("Description should not be empty.");
        }
        while (description == "");
        
        transactionList.Add(
            new Transaction(day, month, year, amount, description));
    }
    
    public void AddRepetitiveTransaction()
    {
        string text;
        Console.WriteLine();
        
        do
        {
            Console.Write("Enter the month of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidMonth(text))
                Console.WriteLine("Month not valid.");
        }
        while (! IsValidMonth(text));
        
        byte month = Convert.ToByte(text);
        
        do
        {
            Console.Write("Enter the day of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidDay(text, month))
                Console.WriteLine("Day not valid.");
        }
        while (! IsValidDay(text, month));
        
        byte day = Convert.ToByte(text);
        
        do
        {
            Console.Write("Enter the amount of the transaction: ");
            text = Console.ReadLine();
            
            if (! IsValidNumber(text))
                Console.WriteLine("Not valid amount.");
        }
        while (! IsValidNumber(text));
        
        double amount = Convert.ToDouble(text);
        
        string description;
        
        do
        {
            Console.Write("Enter the description of the transaction: ");
            description = Console.ReadLine();
            
            if (description == "")
                Console.WriteLine("Description should not be empty.");
        }
        while (description == "");

        repetitiveTransactionList.Add(
            new RepetitiveTransaction(day, month, amount, description));
    }
    
    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("Bye!");
    }
    
    public void Run()
    {
        char option;
        
        do
        {
            DisplayMenu();
            
            option = GetOption();
            
            if (option != '0')
            {
                switch (option)
                {
                    case '0':
                        break;
                        
                    case '1':
                        AddTransaction();
                        break;
                        
                    case '2':
                        AddRepetitiveTransaction();
                        break;
                    
                    case '3':
                        ShowTransactions();
                        PressKey();
                        break;
                        
                    case '4':
                        ShowRepetitiveTransactions();
                        PressKey();
                        break;
                        
                    case '5':
                        FindTransactions();
                        PressKey();
                        break;
                        
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid option");
                        PressKey();
                        break;
                }
            }
        }
        while (option != '0');
        End();
    }
    
    public static void Main()
    {
        HomeAccounting myHomeAccounting = new HomeAccounting();
        
        myHomeAccounting.Run();
    }
}
