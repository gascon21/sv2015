// Home accounting
// Chen Chao, simplified by Nacho
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

    public override string ToString()
    {
        return day + "/" + month + "/" + year + " : " + amount + " " + description;
    }
}

// ---------

public class TransactionList
{
    protected Transaction[] transaction;
    protected int max;
    protected int count;

    public TransactionList()
    {
        max = 10000;
        count = 0;
        transaction = new Transaction[max];
    }

    public void Add(Transaction newtransaction)
    {
        transaction[count] = newtransaction;
        count++;
    }

    public int GetLength()
    {
        return count;
    }

    public Transaction GetTransaction(int index)
    {
        return transaction[index];
    }
}

// ---------

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

    public double GetAmount()
    {
        return expectedAmount;
    }

    public string GetDescription()
    {
        return description;
    }

    public override string ToString()
    {
        return day+"/"+month+" : "+expectedAmount + " " + description;
    }
}

// ---------

public class RepetitiveTransactionList
{
    protected RepetitiveTransaction[] transaction;
    protected int max;
    protected int count;

    public RepetitiveTransactionList()
    {
        max = 10000;
        count = 0;
        transaction = new RepetitiveTransaction[max];
    }

    public void Add(RepetitiveTransaction newtransaction)
    {
        transaction[count] = newtransaction;
        count++;
    }

    public int GetLength()
    {
        return count;
    }

    public RepetitiveTransaction GetTransaction(int index)
    {
        return transaction[index];
    }
}

// ---------

public class HomeAccounting
{
    static TransactionList transactionList = new TransactionList();
    static RepetitiveTransactionList repetitiveTransactionList =
        new RepetitiveTransactionList();

    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Add transaction");
        Console.WriteLine("2. Add repetitive transaction");
        Console.WriteLine("3. Show transactions");
        Console.WriteLine("4. Show repetitive transactions");
        Console.WriteLine("5. Find transactions");
        Console.WriteLine("0. Exit");
    }

    public static char GetOption()
    {
        return Console.ReadKey().KeyChar;
    }

    public static void WaitForKey()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }


    public static void AddTransaction()
    {
        Console.WriteLine();

        Console.Write("Enter the year of the transaction: ");
        ushort year = Convert.ToUInt16(Console.ReadLine());

        Console.Write("Enter the month of the transaction: ");
        byte month = Convert.ToByte(Console.ReadLine());

        Console.Write("Enter the day of the transaction: ");
        byte day = Convert.ToByte(Console.ReadLine());

        Console.Write("Enter the amount of the transaction: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the description of the transaction: ");
        string description = Console.ReadLine();

        transactionList.Add(
            new Transaction(day, month, year, amount, description));
    }
    

    public static void AddRepetitiveTransaction()
    {
        Console.WriteLine();

        Console.Write("Enter the month of the transaction: ");
        byte month = Convert.ToByte(Console.ReadLine());

        Console.Write("Enter the day of the transaction: ");
        byte day = Convert.ToByte(Console.ReadLine());

        Console.Write("Enter the amount of the transaction: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the description of the transaction: ");
        string description = Console.ReadLine();

        repetitiveTransactionList.Add(
            new RepetitiveTransaction(day, month, amount, description));
    }


    public static void ShowTransactions()
    {
        bool transactionFound = false;
        Console.WriteLine();

        if (transactionList.GetLength() == 0)
        {
            Console.WriteLine("No transactions registered.");
            return;
        }
        
        Console.Write("Enter the year to display: ");
        int year = Convert.ToInt32(Console.ReadLine());
                
        Console.Write("Enter the month to display: ");
        int month = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < transactionList.GetLength(); i++)
        {
            if (transactionList.GetTransaction(i).GetMonth() == month &&
                    transactionList.GetTransaction(i).GetYear() == year)
            {
                Console.WriteLine(transactionList.GetTransaction(i).ToString());
                transactionFound = true;
            }
        }

        if (!transactionFound)
            Console.WriteLine("No transactions found");            
    }


    public static void ShowRepetitiveTransactions()
    {
        bool transactionFound = false;
        Console.WriteLine();
        
        if (repetitiveTransactionList.GetLength() == 0)
        {
            Console.WriteLine("No transactions registered.");
            return;
        }
        
        Console.Write("Enter the month to display: ");
        int month = Convert.ToInt32(Console.ReadLine());        

        for (int i = 0; i < repetitiveTransactionList.GetLength(); i++)
        {
            if (repetitiveTransactionList.GetTransaction(i).
                    GetMonth() == month)
            {
                Console.WriteLine(repetitiveTransactionList.GetTransaction(i).ToString());
                transactionFound = true;
            }
        }

        if (!transactionFound)
            Console.WriteLine("No transactions found");
    }


    public static void FindTransactions()
    {
        Console.WriteLine();

        if (transactionList.GetLength() > 0 ||
                repetitiveTransactionList.GetLength() > 0)
        {
            Console.Write("Enter text to search: ");
            string text = Console.ReadLine();

            bool transactionFound = false;

            if (text != "")
            {
                for (int i = 0; i < transactionList.GetLength(); i++)
                {
                    if (transactionList.GetTransaction(i).GetDescription()
                            .Contains(text))
                    {
                        Console.WriteLine(transactionList.GetTransaction(i).ToString());
                        transactionFound = true;
                    }
                }

                for (int i = 0; i < repetitiveTransactionList.GetLength(); i++)
                {
                    if (repetitiveTransactionList.GetTransaction(i)
                            .GetDescription().Contains(text))
                    {
                        Console.WriteLine(repetitiveTransactionList.GetTransaction(i).ToString());
                        transactionFound = true;
                    }
                }
            }
            if (!transactionFound)
                Console.WriteLine("No transaction contains the information you " +
                    "entered.");
        }
        else
            Console.WriteLine("No transactions registered.");
    }


    public static void End()
    {
        Console.WriteLine();
        Console.WriteLine("Bye!");
    }


    public static void Main()
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
                        WaitForKey();
                        break;

                    case '4':
                        ShowRepetitiveTransactions();
                        WaitForKey();
                        break;

                    case '5':
                        FindTransactions();
                        WaitForKey();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid option");
                        WaitForKey();
                        break;
                }
            }
        }
        while (option != '0');
        End();
    }
}
