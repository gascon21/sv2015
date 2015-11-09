/// <summary>
///  Home accounting
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.06  06-Nov-2015  Sacha Van de Sijpe: Array of structs
   0.05  30-Oct-2015  Victor Carretero: Parallel arrays (up to 100.000 Transaction)
   0.04  30-Oct-2015  Victor Carretero: Parallel arrays (still one transactions)
   0.03  23-Oct-2015  José Vicente Leal: Display one transactions
   0.02  23-Oct-2015  Vicente Cuenca: Enter one transactions
   0.01  16-Oct-2015  Jorge Montalvo: Main menu (switch)
 ---------------------------------------------------- */

using System;

public class HomeAccounting
{
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
    public static void Main()
    {
        const int SIZE = 100000;
        byte option;
        uint numElements = 0;
        Transaction [] transactions = new Transaction [SIZE];
        
        do
        {
            Console.WriteLine("1.-Add expense or income");
            Console.WriteLine("2.-View last Transaction");
            Console.WriteLine("3.-Monthly Transaction");
            Console.WriteLine("4.-Account totals");
            Console.WriteLine("0.-Exit");
            
            option = Convert.ToByte(Console.ReadLine());
            
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    
                    Console.WriteLine("Enter the amount:");
                    transactions[numElements].amounts = 
                        Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Enter the description:");
                    transactions[numElements].descriptions = 
                        Console.ReadLine();
                    
                    Console.WriteLine("Enter the day:");
                    transactions[numElements].days = 
                        Convert.ToByte(Console.ReadLine());
                    
                    Console.WriteLine("Enter the month:");
                    transactions[numElements].months = 
                        Convert.ToByte(Console.ReadLine());
                    
                    Console.WriteLine("Enter the year:");
                    transactions[numElements].years = 
                        Convert.ToUInt16(Console.ReadLine());
                    
                    Console.WriteLine("Enter the account:");
                    transactions[numElements].accounts = 
                        Console.ReadLine();
                    
                    Console.WriteLine("Enter the category:");
                    transactions[numElements].categories = 
                        Console.ReadLine();
                    
                    numElements++;
                    Console.WriteLine();
                    break;
                    
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
