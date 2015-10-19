/*Adrian Navarro Garcia
program to ask the user for two real numbers and display their division.
*/
using System;
public class NumDouble
{
    public static void Main ()
    {
        double num1,num2;
        
        Console.WriteLine("number 1 ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("number 2");
        num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Division is {0}",num1 / num2);
    }
}
