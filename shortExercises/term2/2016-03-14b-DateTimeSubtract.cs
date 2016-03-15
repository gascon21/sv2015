// Ruben Blanco
// Program: Date Time

using System;

public class DateTimeSubtract
{
    public static void Main()
    {
        Console.Write("Enter the day you were born: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the month you were born: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the year you were born: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime hoy = DateTime.Now;
        DateTime birthDate = new DateTime(year, month, day);

        TimeSpan diff = hoy.Subtract(birthDate);

        Console.WriteLine("{0} days elapsed since you were born", 
            diff.Days);
    }
}
