// Ruben Blanco
// Program: ExceptionsSqrt

using System;

public class ExceptionsSqrt
{
    public static void Main()
    {
        double number, squareRoot;
        
        Console.Write("Insert a number: ");
        try
        {
			number = Convert.ToDouble(Console.ReadLine());
            squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root = {0}",squareRoot);
        }
        catch( Exception )
        {
			Console.WriteLine("Gotcha!");
		}
		Console.WriteLine("And the life goes on...");
        
    }
}
        
