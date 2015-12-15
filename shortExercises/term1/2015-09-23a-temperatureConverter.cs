/*
 * José Miguel Leonis 
 * Convert from celsius degrees to Kelvin and Fahrenheit
 */
 
 using System;
 public class ej09
 {
     public static void Main()
     {
        int celsius,fahrenheit, kelvin;

        Console.WriteLine("How Many celsius want to convert?");
        celsius = Convert.ToInt32(Console.ReadLine());
        
        kelvin = celsius+273;
        fahrenheit = celsius * 18 / 10 + 32;
        Console.WriteLine("{0} celsius are {1} kelvin and {2} fahrenheit", 
            celsius,kelvin,fahrenheit);
     }
 }
