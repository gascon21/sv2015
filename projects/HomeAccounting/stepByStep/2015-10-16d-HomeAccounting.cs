/// <summary>
///  Home accounting
///  @author Students at IES San VIcente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.01  16-Oct-2015  Jorge Montalvo: Main menu (switch)
 ---------------------------------------------------- */

using System;

public class HomeAccounting
{
    public static void Main()
    {
        
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
                    Console.WriteLine("Option not avaliable");
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
