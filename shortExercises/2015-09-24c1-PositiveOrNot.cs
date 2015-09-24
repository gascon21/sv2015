// Adrian Navarro Garcia
// This program tells if the number is positive, negative or 0
using System;
public class PosNegZero
{
    public static void Main()
    {
        Console.WriteLine("Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
            Console.WriteLine("The number is negative(-)");
        else if (num > 0)
            Console.WriteLine("The number is positive(+)");
        else
            Console.WriteLine("The number is 0");
    }
}
