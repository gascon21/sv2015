// Quinto ejemplo de clase: Ocultar detalles

using System;

public class Taburete
{
    byte alturaCm;
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
    
    // public int LeerAltura()
    // public int ObtenerAltura()
    public int GetAltura()
    {
        return alturaCm;
    }
    
}


public class PruebaTaburete
{
    public static void Main()
    {
        Taburete tabureteDeRuben = new Taburete();
        tabureteDeRuben.SetAltura(65);
        Console.WriteLine("La altura es " +
            tabureteDeRuben.GetAltura() );
        tabureteDeRuben.Subir();
        tabureteDeRuben.Subir();
        tabureteDeRuben.Bajar();
    }
}
