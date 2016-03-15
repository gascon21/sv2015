// Generador para el problema "Vehiculos ecologicos"


using System;

public class GeneradorC
{
    public static void Main()
    {
        int n = 49999;
        Random r = new Random();
        
        Console.WriteLine(n);
        for (int i=0; i < n; i++)
        {
            Console.WriteLine("V"+i.ToString("00000"));
            Console.WriteLine("{0} {1} {2} {3}",
                r.Next(0,1000), r.Next(0,1000),
                r.Next(0,1000), r.Next(0,1000)
            );
        }
    }
}
