/* Adrian Navarro garcia
program which asks the user for two integer numbers and displays 
* their power.
* */
using System;

public class Power
{
    public static void Main()
    {
        int result=1;
        
        Console.Write("Enter the base ");
        int base1 = Convert.ToInt32(Console.ReadLine());
        
         Console.Write("Enter the exponent ");
        int exponent = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i<=exponent;i++)
            result *= base1;
        
        Console.WriteLine(result);
        
    }
}
