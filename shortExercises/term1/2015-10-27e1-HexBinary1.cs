/* Sergio Martínez Mira
 * HexAndBinary
 * */

using System;

public class HexAndBinary
{
    public static void Main()
    {
        Console.Write("Enter the number to convert: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        while (n != -1)
        {
            Console.WriteLine(Convert.ToString(n,16));
            Console.WriteLine(Convert.ToString(n,2));
            
            Console.Write("Enter another number to convert: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

    }
}
