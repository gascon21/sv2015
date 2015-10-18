# Home accounting - Evolution

## Version 0.01a : Display the main menu

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
