/*
 * Divide two numbers. Second one must be non-zero ("while")
 */
using System;
public class DivideWhileZero
{
    public static void Main()
    {
        int numerator, denominator;
        
        Console.Write("Enter the numerator: ");
        numerator=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the denominator: ");
        denominator=Convert.ToInt32(Console.ReadLine());
        
        while (denominator == 0)
        {
            Console.Write("Denominator must not be zero: ");
            denominator=Convert.ToInt32(Console.ReadLine());
        }
            
        Console.WriteLine("The division is: {0}",
            numerator / denominator);
    }
}

