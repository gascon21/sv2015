# Home accounting - Evolution

## Version 0.01 : Display the main menu

```csharp
int option;

do
{
    Console.WriteLine("1.-Add expense or income");
    Console.WriteLine("2.-View last transactions");
    Console.WriteLine("3.-Monthly transactions");
    Console.WriteLine("4.-Account totals");
    Console.WriteLine("0.-Exit");
    
    option = Convert.ToInt32(Console.ReadLine());
    
    switch (option)
    {
        case 0:
            break;
        case 1:
        case 2:
        case 3:
        case 4:
            Console.WriteLine("Option not avaliable");
            break;
        default:
            Console.WriteLine("Unknown option");
            break;
    }
}
while(option!=0);
```

## Version 0.02 : Enter one transaction

```csharp
byte day, month;
ushort year;
double amount;
string description, account, category;
...
Console.WriteLine("Enter the amount:");
amount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the description:");
description = Console.ReadLine();

Console.WriteLine("Enter the day:");
day = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Enter the month:");
month = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Enter the year:");
year = Convert.ToUInt16(Console.ReadLine());

Console.WriteLine("Enter the account:");
account = Console.ReadLine();

Console.WriteLine("Enter the category:");
category = Console.ReadLine();
```


## Version 0.03 : Display one transaction

```csharp
byte day=1, month=1;
ushort year=2015;
double amount=0;
string description="expense", account="cash", category="food";
...
case 2:
    Console.WriteLine("{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
        day.ToString("00"), month.ToString("00"),year.ToString("0000"),
        amount,description,category, account);
    break;
```


## Version 0.04 : Parallel arrays (but still one transaction)

```csharp
const int SIZE = 100000;
byte option;
byte[] days = new byte[SIZE];
byte[] months = new byte[SIZE];
ushort[] years = new ushort [SIZE];
double[] amounts = new double[SIZE];
string[] descriptions = new string[SIZE];
string[] accounts = new string[SIZE];
string[] categories = new string[SIZE];
...
case 1:
    Console.WriteLine("Enter the amount:");
    amounts[0] = Convert.ToDouble(Console.ReadLine());
    ...
    break;
...
case 2:
    Console.WriteLine("{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
        days[0].ToString("00"), months[0].ToString("00"),years[0].ToString("0000"),
        amounts[0],descriptions[0],categories[0], accounts[0]);
    break;
```


## Version 0.05 : Parallel arrays (up to 100,000 transactions)

```csharp
uint numElements = 0;
...
case 1:
    Console.WriteLine("Enter the amount:");
    amounts[numElements] = Convert.ToDouble(Console.ReadLine());
    ...
    numElements++;    
    break;
...
case 2:
    for (uint i = 0; i < numElements; i++)
        Console.WriteLine("{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
            days[i].ToString("00"), months[i].ToString("00"),years[i].ToString("0000"),
            amounts[i],descriptions[i],categories[i], accounts[i]);
    break;
```



## Version 0.06 : Array of structs

```csharp
struct Transaction
{
    public byte days;
    public byte months;
    public ushort years;
    public double amounts;
    public string descriptions;
    public string accounts;
    public string categories;
}
...
Transaction[] transactions = new Transaction [SIZE];
...
case 1:
    Console.WriteLine("Enter the amount:");
        transactions[numElements].amounts = 
            Convert.ToDouble(Console.ReadLine());
    ...
    numElements++;    
    break;
...
case 2:
    for (uint i = 0; i < numElements; i++)
        Console.WriteLine(
            "{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
            transactions[i].days.ToString("00"), 
            transactions[i].months.ToString("00"),
            transactions[i].years.ToString("0000"),
            transactions[i].amounts,
            transactions[i].descriptions,
            transactions[i].categories, 
            transactions[i].accounts);
    break;
```


## Version 0.07 : Split into functions (first approach)

```csharp
const int SIZE = 100000;
static Transaction [] transactions = new Transaction [SIZE];
static uint numElements = 0;

public static void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("1.-Add expense or income");
    Console.WriteLine("2.-View last Transactions");
    Console.WriteLine("3.-Monthly Transactions");
    Console.WriteLine("4.-Account totals");
    Console.WriteLine("0.-Exit");
}
...
public static void Main()
{
    char option;
    do
    {
        DisplayMenu();
        option = GetOption();
```


## Version 0.08 : Split into functions (finished)

```csharp
public static void AddTransaction()
{
    ...
}


public static void ViewLastTransactions()
{
    ...
}
    
...
switch (option)
{
    case '0':
        break;
        
    case '1':
        AddTransaction();
        break;
        
    case '2':
        ViewLastTransactions();
        break;
```

## Version 0.09 : Transactions in a month

```csharp
public static void ViewTransactionsMonth()
{
    ushort searchyear;
    byte searchmonth;
    Console.Write("Enter year: ");
    searchyear = Convert.ToUInt16(Console.ReadLine());
    Console.Write("Enter the month: ");
    searchmonth = Convert.ToByte(Console.ReadLine());
    
    for( uint i = 0; i<numElements;i++)
    {
        if( transactions[i].years == searchyear && 
            transactions[i].months == searchmonth )
                Console.WriteLine(
                    "{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
                    transactions[i].days.ToString("00"), 
                    transactions[i].months.ToString("00"),
                    transactions[i].years.ToString("0000"),
                    transactions[i].amounts,
                    transactions[i].descriptions,
                    transactions[i].categories, 
                    transactions[i].accounts);
    }
}
```


## Version 0.10 : Sort by month and day

```csharp
public static void AddTransaction()
{
    ...
    numElements++;
    Sort();
}

public static void Sort()
{
    for (uint i = 0 ; i < numElements - 1 ; i++)
        for (uint j = i + 1 ; j < numElements ; j++)
        {
            if ((transactions[i].months.ToString("00") +
                    transactions[i].days.ToString("00")).CompareTo(
                    transactions[j].months.ToString("00") +
                    transactions[j].days.ToString("00")) > 0 )
            {
                Transaction temp = transactions[i];
                transactions[i] = transactions[j];
                transactions[j] = temp;
            }
        }
}    
```
