/*
* José Miguel Leonis 

* Create a C# program to ask the user for three integer numbers and 
* display:

* - The first number incremented 
* - The second number divided by 3 
* - The third number decreased by 5 
 */

using System;
public class AbreviatedOperations
{
    public static void Main()
    {
        int number1, number2, number3;
        
        Console.Write("Enter a number: ");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a second: ");
        number2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a third: ");
        number3=Convert.ToInt32(Console.ReadLine());
        
        number1++;
        number2 /= 3;
        number3 -= 5;
        
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);
    }
}
