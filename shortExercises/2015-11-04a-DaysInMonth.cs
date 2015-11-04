// Days of daysInMonth

using System;

public class DaysMonths
{
    public static void Main()
    {
        int[] daysInMonth = {31, 28, 31, 30, 31, 30, 
                31, 31, 30, 31, 30, 31};
        
        Console.Write("Choose a month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("The month {0} has: {1} Days. ", 
            month, daysInMonth[ month-1 ]);
    }
}
