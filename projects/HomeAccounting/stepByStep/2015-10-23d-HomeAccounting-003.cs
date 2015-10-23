/// <summary>
///  Home accounting
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.03  23-Oct-2015  José Vicente Leal: Display one transaction
   0.02  23-Oct-2015  Vicente Cuenca: Enter one transaction
   0.01  16-Oct-2015  Jorge Montalvo: Main menu (switch)
 ---------------------------------------------------- */

using System;

public class HomeAccounting
{
    public static void Main()
    {
        
        byte option;
        byte day=1, month=1;
        ushort year=2015;
        double amount=0;
        string description="expense", account="cash", category="food";
        
        do
        {
            Console.WriteLine("1.-Add expense or income");
            Console.WriteLine("2.-View last transactions");
            Console.WriteLine("3.-Monthly transactions");
            Console.WriteLine("4.-Account totals");
            Console.WriteLine("0.-Exit");
            
            option = Convert.ToByte(Console.ReadLine());
            
            switch (option)
            {
                case 0:
                    break;
                case 1:
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
                    
                    Console.WriteLine();
                    break;
                    
                case 2:
                    Console.WriteLine("{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
                        day.ToString("00"), month.ToString("00"),year.ToString("0000"),
                        amount,description,category, account);
                    break;
                    
                case 3:
                    Console.WriteLine("Option not available");
                    break;
                    
                case 4:
                    Console.WriteLine("Option not available");
                    break;
                    
                default:
                    Console.WriteLine("Unknown option");
                    break;
            }
        }
        while(option!=0);
    }
}
