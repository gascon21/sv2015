/*Adrian Navarro Garcia
program to ask the user for two real numbers and display their division.
*/
using System;
public class NumFloat
{
    public static void Main ()
    {
        float num1,num2;
        
        Console.WriteLine("number 1 ");
        num1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("number 2");
        num2 = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Division is {0}",num1 / num2);
    }
}
