// Is Prime?

using System;

public class IsPrime
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int dividers = 0;
        int i=1;

        while( i <= number )
        {
            if (number % i ==0 )
                dividers = dividers + 1;

            i=i+1;
        }

        if (dividers == 2)
            Console.Write("It's a prime number");
        else
            Console.Write("It's not a prime number");
    }
}
