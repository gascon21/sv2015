/* Ruben Blanco Couce
Converting miles to meters
Second version, as an example of {0}
*/

/*
A mile (also called a "land mile") equals 1609 meters.

Write a C# program to ask the user for an amount of miles and display the 
equivalence in meters. For instance, if the user enters 3, the answer would be:

3 land miles = 4827 meters
*/

using System;

public class MilesToMeters
{
    public static void Main()
    {
        // we declare variables
        int miles,meters;

        // we ask the user for data
        Console.WriteLine ("Enter the miles to convert to meters");
        miles = Convert.ToInt32 (Console.ReadLine () );

        // now we calculate
        // (1 mile = 1609 meters)
        meters = miles * 1609;

        // and finally we display the results
        Console.WriteLine ("{0} miles are equal to {1} meters",
            miles, meters);
    }

}
