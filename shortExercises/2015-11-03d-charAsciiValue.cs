// Numerical value of a "char" (ACII code):
// Convert.ToInt32("1") is 1, but
// Convert.ToInt32('1') is 49 (its ASCII code)

using System;
public class CharValue
{
    public static void Main()
    {
        Console.WriteLine("Numerical value of 1 as a string is {0}", 
            Convert.ToInt32("1"));
        Console.WriteLine("Numerical value of 1 as a char is {0}", 
            Convert.ToInt32('1'));
            
        Console.Write("Enter a letter: ");
        char letter = Convert.ToChar( Console.ReadLine() );
        Console.WriteLine("Its numerical value is {0}", 
            Convert.ToInt32(letter));

        for (byte symbol = 32; symbol <= 127; symbol++)
            Console.Write( "{0}={1}   ", 
                symbol.ToString("000"), 
                Convert.ToChar(symbol) );
            
        Console.WriteLine();
    }
}


