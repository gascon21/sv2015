// Ruben Blanco
// Divide if not zero

using System;

public class DivideIfNotZero
{
    public static void Main()
    {
        int x, y;
        Console.Write("Write the first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Write the second number: ");
        y = Convert.ToInt32(Console.ReadLine());
        
        if (y == 0) 
            Console.WriteLine("I cannot divide by zero.");
        else
            Console.WriteLine("The division of {0} and {1} is: {2}", 
                x, y, x/y);
    }
}
