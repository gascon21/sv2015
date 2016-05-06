// Multiply one big number by one digit
// Chen Chao
// 05-05-2016

using System;

public class Multiply
{
    public static void Main()
    {
        Console.Write("Enter the long number: ");
        string longNumber = Console.ReadLine();
        Console.Write("Enter the one-digit multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());
        
        string total = "";
        int partialResult = 0;
        int digit = 0;
        int carry = 0;
        for (int i = longNumber.Length - 1; i >= 0; i--)
        {
            digit = longNumber[i] - '0';
            partialResult = digit * multiplier + carry;
            carry = partialResult / 10;
            total = "" + (partialResult % 10) + total;
        }
        
        if (carry > 0)
            total = "" + carry + total;
        Console.WriteLine("The partialResult is: {0}", total);
    }
}
