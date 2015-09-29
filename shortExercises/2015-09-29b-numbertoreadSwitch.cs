/* Sergio Martínez Mira
 * Ask for a number till 5 and reads it for you
 * Version 2: switch
 * */

using System;

public class NumberToRead
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Enter the number to read:");
        n = Convert.ToInt32(Console.ReadLine());
            
        switch ( n )
        {
            case 1:
                Console.WriteLine("One"); 
                break;
            case 2:
                Console.WriteLine("Two"); 
                break;
            case 3:
                Console.WriteLine("Three"); 
                break;
            case 4:
                Console.WriteLine("Four"); 
                break;
            case 5:
                Console.WriteLine("Five"); 
                break;
            default:
                Console.WriteLine("Unknown!"); 
                break;
        }
    }
}
