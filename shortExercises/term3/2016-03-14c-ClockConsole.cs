//Adrian Navarro Garcia
using System;
using System.Threading;
public class Program
{
    public static void Main()
    {
        Console.Clear();
        while(true)
        {
            DateTime hoy = DateTime.Now;

            Console.SetCursorPosition(70, 1);
            Console.WriteLine(hoy.Hour.ToString("00") 
                + ":" + hoy.Minute.ToString("00") 
                + ":"+ hoy.Second.ToString("00"));
            Thread.Sleep(1000);
        }
      
    }
}
