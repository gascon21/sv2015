// Primer ejemplo de clase: Taburete

using System;

public class Taburete
{
    int alturaCm;
    int numPatas;
    
    public void Subir()
    {
        Console.WriteLine("Subiendo");
    }
    
    public void Bajar()
    {
        Console.WriteLine("Bajando");
    }
}


public class PruebaTaburete
{
    public static void Main()
    {
        Taburete tabureteDeRuben = new Taburete();
        tabureteDeRuben.Subir();
        tabureteDeRuben.Subir();
        tabureteDeRuben.Bajar();
    }
}
