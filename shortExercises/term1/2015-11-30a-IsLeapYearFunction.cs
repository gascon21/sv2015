using System;

public class LeapYear
{
    public static bool IsLeapYear(ushort number)
    {
        if (number % 400 == 0 )
            return true;

        if ((number %4 == 0)&& (number %100 != 0))
            return true;

        return false;
    }
    
    public static void Main()
    {
        if (IsLeapYear(1600))
            Console.WriteLine("Is leap year");
        else
             Console.WriteLine("not leap year");
    }
}
