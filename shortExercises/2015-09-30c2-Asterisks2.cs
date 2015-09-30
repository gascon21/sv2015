// Asterisks

using System;

public class Asterisks2
{
    public static void Main()
    {
        Console.Write("Enter the amount of asterisks: ");
        int n = Convert.ToInt32( Console.ReadLine() );

        while( n > 0 )
        {
            Console.Write("*");
            n=n-1;
        }
        Console.WriteLine();
    }
}
