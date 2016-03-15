// Mónica Esteve 
using System;
 
public class DateTimeTest
{
    public static void Main()
    {
        DateTime hoy = DateTime.Now;

        Console.WriteLine("Son las " +  
            hoy.Hour.ToString("00") + 
            ":" + hoy.Minute.ToString("00") + 
            ":" + hoy.Second.ToString("00") +
            " del día " + hoy.Day.ToString("00") +  
            "/" + hoy.Month.ToString("00") + 
            "/" + hoy.Year );
    }
}
 
