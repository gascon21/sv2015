/*
Create a program to ask the user for a number and calculate a 
estimation for its square root (testing all the possible values).

Examples:

SQR(81) = 9 (exact)

SQR(145) = 12 (approx)

SQR(168) = 13 (approx)
*/

using System;

public class Sqr
{
    public static void Main()
    {
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
            if (i*i == n)
            {
                Console.WriteLine("Square root is: {0}", i);
                break;
            }
    }
}
