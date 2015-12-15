/*  
 * Create a C# program to ask the user for the number of a month (for 
 * example, 4 would mean April) and display the amount of days in that 
 * month (for example, 30 if the user chooses April).
 * 
 * You must do it first using "if" and then using "switch".
 *  07/10/2015
*/
using System;
public class days
{
    public static void Main()
    {
        int month;
        
        Console.Write("Enter a number of month: ");
        month = Convert.ToInt32(Console.ReadLine());
                        
        if (month == 1 || month == 3 || month == 5 || month == 7 
                || month == 8 || month == 10 || month == 12)
            Console.WriteLine("31");
        else if (month == 4 || month == 6 || month == 9 || month == 11)
            Console.WriteLine("30");
        else if (month == 2)
            Console.WriteLine("28");
            
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("31");
                break;
            case 2:
                Console.WriteLine("28");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("30");
                break;
        }

                                                                                                          
    }
}
