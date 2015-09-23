// Ruben Blanco Couce, Sacha Van de sijpe bueno
// Program to convert miles to meters with 3 decimals

using System;

public class MilesToMeters
{
    public static void Main ()
    {
        int meter1, meter2, miles, x;
        
        meter1 = 1609;
        meter2 = 344;
        
        Console.WriteLine("Write miles to show distance at meters");
        miles = Convert.ToInt32(Console.ReadLine() );
        
        x = (meter2*miles/1000);
        
        Console.WriteLine("{0} miles are {1},{2} meter", miles,
        meter1*miles + x, miles*meter2 - x*1000);
    }
}
