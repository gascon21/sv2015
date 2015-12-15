// Asterisks

using System;

public class Asterisks
{
    public static void Main()
    {
        Console.Write("Enter the amount of asterisks: ");
        int n = Convert.ToInt32( Console.ReadLine() );
        int i=1;

        while( i <= n )
        {
            Console.Write("*");
            i=i+1;
        }
        Console.WriteLine();
    }
}
