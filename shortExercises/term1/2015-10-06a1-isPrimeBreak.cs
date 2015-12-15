// Gonzalo García Soler
// Is Prime? v2

using System;

public class IsPrimeFor
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int dividers = 0;
        int i=1;

        for (i=1; i<= number; i++ )
        {
            if (number % i ==0 )
                dividers = dividers + 1;
            if (dividers >= 3) 
                break;
        }
        
        if (dividers == 2)
            Console.WriteLine("It's a prime number");
        else
            Console.WriteLine("It's not a prime number");
    }
}
