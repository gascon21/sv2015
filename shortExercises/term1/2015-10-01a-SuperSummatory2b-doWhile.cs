/*
 * Write a C# program to ask the user for integer numbers and 
 * display their sum. It must repeat until the number is zero.
 */
 
using System;
public class SuperSummatory2
{
    public static void Main()
    {
        int n;
        int sum = 0;
        
        do
        {
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
          
            if (n != 0)
            {
                sum = sum + n;
                Console.WriteLine("Sum is {0}", sum);
            }
        }
        while (n != 0);

        Console.WriteLine("See you!");
    }
}

