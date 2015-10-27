/* Sergio Martínez Mira
 * HexAndBinary
 * */

using System;

public class HexAndBinary2
{
    public static void Main()
    {
        int n = 0;
        
        do
        {
            Console.Write("Enter the number to convert: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n != -1)
            {
                Console.WriteLine(Convert.ToString(n,16));
                Console.WriteLine(Convert.ToString(n,2));
            }
        }
        while (n != -1);

    }
}
