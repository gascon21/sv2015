// Juan Salinas Gómez
// Display speed
// Create a C# program to ask the user for the amount of miles that 
// an object has moved and the seconds it has taken, and display its 
// speed in m/s, km/h, mi/h

using System;

public class Speed
{
    public static void Main()
    {
        int miles, seconds;
        
        int metersPerSecond;
        int milesPerHour;
        int kmPerHour;
        
        Console.Write("Enter miles: ");
        miles = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter seconds: ");
        seconds = Convert.ToInt32(Console.ReadLine());
        
        metersPerSecond = miles * 1609 / seconds;
        Console.WriteLine("{0} m/s", metersPerSecond);
        
        milesPerHour = 3600 * miles / seconds ;
        Console.WriteLine("{0} mph", milesPerHour);
        
        kmPerHour = 3600 * (miles * 1609 / 1000) / seconds;
        Console.WriteLine("{0} km/h", kmPerHour);
    }
}
