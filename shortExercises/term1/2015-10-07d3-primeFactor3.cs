// Write a program which asks the user for an integer number and displays 
// its prime factors. For example, 15 = 3 * 5, 24 = 2 * 2 * 2 * 3

// (Hint: it can be easier if the solution is displayed as 
// 60 = 2 · 2 · 3 · 5 · 1)

// Not a recommended way

using System;
public class PrimeFactors
{
    public static void Main() 
    {

        Console.Write("Number to find the prime factors? ");
        int n =Convert.ToInt32(Console.ReadLine());
        int divider;
        
        for (divider = 2; divider <= n; divider++)
        {
            if (n % divider == 0)
            {
                Console.Write("{0} · ", divider);
                n /= divider;
                
                divider--;
            }
        }
        Console.WriteLine("1");
    }
}
