/// <summary>
///  Home accounting
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.04  30-Oct-2015  Victor Carretero: Parallel arrays (still one transaction)
   0.03  23-Oct-2015  José Vicente Leal: Display one transaction
   0.02  23-Oct-2015  Vicente Cuenca: Enter one transaction
   0.01  16-Oct-2015  Jorge Montalvo: Main menu (switch)
 ---------------------------------------------------- */

using System;

public class HomeAccounting
{
    public static void Main()
    {
        const int SIZE = 100000;
        byte option;
        byte[] days = new byte[SIZE];
        byte[] months = new byte[SIZE];
        ushort[] years = new ushort [SIZE];
        double[] amounts = new double[SIZE];
        string[] descriptions = new string[SIZE];
        string[] accounts = new string[SIZE];
        string[] categories = new string[SIZE];
        
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
                    amounts[0] = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Enter the description:");
                    descriptions[0] = Console.ReadLine();
                    
                    Console.WriteLine("Enter the day:");
                    days[0] = Convert.ToByte(Console.ReadLine());
                    
                    Console.WriteLine("Enter the month:");
                    months[0] = Convert.ToByte(Console.ReadLine());
                    
                    Console.WriteLine("Enter the year:");
                    years[0] = Convert.ToUInt16(Console.ReadLine());
                    
                    Console.WriteLine("Enter the account:");
                    accounts[0] = Console.ReadLine();
                    
                    Console.WriteLine("Enter the category:");
                    categories[0] = Console.ReadLine();
                    Console.WriteLine();
                    break;
                    
                case 2:
                    Console.WriteLine("{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
                        days[0].ToString("00"), months[0].ToString("00"),years[0].ToString("0000"),
                        amounts[0],descriptions[0],categories[0], accounts[0]);
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
