/* A program that asks the user for a positive integer number 
 * and displays its equivalent in binary form
 * Version 3: Using a string
 * */

using System;

public class Binary
{
    public static void Main()
    {
        Console.WriteLine("Enter the number to convert to Binary: ");
        uint n = Convert.ToUInt32(Console.ReadLine());

        string binarydata = "";
        while (n > 0)
        {
            binarydata = Convert.ToString(n%2) + binarydata;
            n /=2;
        }
        Console.WriteLine(binarydata);
    }
}
