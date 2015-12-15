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
            
            
        if ( month == 1)
            Console.WriteLine("31");
        else if ( month == 2)
            Console.WriteLine("28");
        else if ( month == 3)
            Console.WriteLine("31");            
        else if ( month == 4)
            Console.WriteLine("30");
        else if ( month == 5)
            Console.WriteLine("31");
        else if ( month == 6)
            Console.WriteLine("30");
        else if ( month == 7)
            Console.WriteLine("31"); 
        else if ( month == 8)
            Console.WriteLine("31");
        else if ( month == 9)
            Console.WriteLine("30");
        else if ( month == 10)
            Console.WriteLine("31");
        else if ( month == 11)
            Console.WriteLine("30");
        else
            Console.WriteLine("31"); 
            
        switch (month)
        {
            case 1:
                Console.WriteLine("31");
                break;
            case 2:
                Console.WriteLine("28");
                break;
            case 3:
                Console.WriteLine("31");
                break;
            case 4:
                Console.WriteLine("30");
                break;
            case 5:
                Console.WriteLine("31");
                break;
            case 6:
                Console.WriteLine("30");
                break;
            case 7:
                Console.WriteLine("31");
                break;
            case 8:
                Console.WriteLine("31");
                break;
            case 9:
                Console.WriteLine("30");
                break;
            case 10:
                Console.WriteLine("31");
                break;
            case 11:
                Console.WriteLine("30");
                break;
            case 12:
                Console.WriteLine("31");
                break;
        }

                                                                                                          
    }
}
