/* Sergio Martínez Mira
 * Ask for a number till 5 and reads it for you
 * */

using System;

public class NumberToRead
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Enter the number to read:");
        n = Convert.ToInt32(Console.ReadLine());
            
        if (n == 1)
            Console.WriteLine("One"); 
        else if (n == 2)
            Console.WriteLine("Two"); 
        else if (n == 3)
            Console.WriteLine("Three"); 
        else if (n == 4)
            Console.WriteLine("Four"); 
        else if (n == 5)
            Console.WriteLine("Five"); 
        else
            Console.WriteLine("Unknown!"); 
    }
}
