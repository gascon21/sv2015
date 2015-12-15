// Tercer ejemplo de clase: Set

using System;

public class Taburete
{
    int alturaCm;
    int numPatas;
    
    public void Subir()
    {
        Console.WriteLine("Subiendo");
        alturaCm += 2;
        Console.WriteLine("Altura actual: " + alturaCm);
    }
    
    public void Bajar()
    {
        Console.WriteLine("Bajando");
        alturaCm -= 2;
        Console.WriteLine("Altura actual: " + alturaCm);
    }
    
    // public void CambiarAltura()
    // public void AsignarAltura()
    // public void FijarAltura()
    // public void EstablecerAltura()
    public void SetAltura( int alturaInicial )
    {
        alturaCm = alturaInicial;
    }
    
}


public class PruebaTaburete
{
    public static void Main()
    {
        Taburete tabureteDeRuben = new Taburete();
        tabureteDeRuben.SetAltura(65);
        tabureteDeRuben.Subir();
        tabureteDeRuben.Subir();
        tabureteDeRuben.Bajar();
    }
}
