/*
Create a program to ask the user for a number and calculate a 
estimation for its square root (testing all the possible values).
Display only the integer part of the square root.

Examples:

SQR(81) = 9 (exact)

SQR(145) = 12 (approx)

SQR(168) = 12 (approx)
*/

using System;

public class Sqr3
{
    public static void Main()
    {
        int i;
        
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (i = 1; i <= n; i++)
        {
            if (i*i == n)
            {
                Console.WriteLine("Square root is: {0} (exact)", i);
                break;
            }
            else if (i*i > n)
            {
                Console.WriteLine("Square root is: {0} (approx)", i-1);
                break;
            }
        }
    }
}
