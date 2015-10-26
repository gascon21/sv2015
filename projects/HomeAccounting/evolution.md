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