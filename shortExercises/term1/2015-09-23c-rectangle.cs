/* Sergio Martínez Mira
 * Rectangle with a number
 * */

using System;

public class rectangle
{
    public static void Main()
    {
        int number;
        
        number = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("{0}{0}{0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0}{0}{0}", number);
    }
}
