/* A program that asks the user for a positive integer number 
 * and displays its equivalent in binary form
 * (Version 2: using an array of fixed size = 32 bits)
 */

using System;

public class Binary
{
    public static void Main()
    {
        Console.WriteLine("Enter the number to convert to Binary: ");
        uint n = Convert.ToUInt32(Console.ReadLine());
        byte digits = 0;

        uint[] binarydata = new uint[32];

        while (n > 0)
        {
            binarydata[digits] = n%2;
            digits++;
            n /=2;
        }

        for (int i = digits-1; i >= 0; i--)
            Console.Write(binarydata[i]);
        Console.WriteLine();
    }
}
