// David Gascón López
/*
    1.12.4.- Create a program that converts degrees Celsius (centigrade)
    and Fahrenheit Kelvin: It will ask the user how many degrees Celsius. Used
    "Write" instead of "{0}" when you must display various data on the same line.
*/

using System;
public class SeptemberReview6
{
    public static void Main()
    {
        int celsius;
        
        Console.Write("Enter degrees Celsius: ");
        celsius = Convert.ToInt32(Console.ReadLine());
        
        Console.Write(celsius);
        Console.Write(" degrees Clesius are: ");
        Console.Write(celsius + 273);
        Console.Write(" degrees Kelvins and ");
        Console.Write(celsius * 18 / 10 + 32);
        Console.WriteLine(" degrees Fahrenheit");
    }
}





