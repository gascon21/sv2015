// Segundo ejemplo de clase: Taburete y atributos públicos (!!!!!)

using System;

public class Taburete
{
    public int alturaCm;
    public int numPatas;
    
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
        tabureteDeRuben.alturaCm = 70;
        tabureteDeRuben.Subir();
        tabureteDeRuben.Subir();
        tabureteDeRuben.Bajar();
    }
}
