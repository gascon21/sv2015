/// <summary>
///  Home accounting
///  @author Students at IES San VIcente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.02  23-Oct-2015  Vicente Cuenca: Enter one transaction
   0.01  16-Oct-2015  Jorge Montalvo: Main menu (switch)
 ---------------------------------------------------- */

using System;

public class HomeAccounting
{
    public static void Main()
    {
        
        byte option;
        byte day, month;
        ushort year;
        double amount;
        string description, account, category;        
        
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
                    Console.WriteLine("Option not avaliable");
                    break;
                case 3:
                    Console.WriteLine("Option not avaliable");
                    break;
                case 4:
                    Console.WriteLine("Option not avaliable");
                    break;
                default:
                    Console.WriteLine("Unknown option");
                    break;
            }
        }
        while(option!=0);
    }
}
