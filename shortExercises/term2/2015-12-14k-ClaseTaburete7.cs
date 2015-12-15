// Séptimo ejemplo de clase: Sobrecarga

using System;

public class Taburete
{
    byte alturaCm;
    int numPatas;
    
    public Taburete()
    {
        alturaCm = 70;
        numPatas = 4;
    }
    
    public Taburete(int nuevaAlturaCm)
    {
        alturaCm = (byte) nuevaAlturaCm;
        numPatas = 4;
    }
    
    public void Subir()
    {
        Console.WriteLine("Subiendo");
        alturaCm += 2;
        Console.WriteLine("Altura actual: " + alturaCm);
    }
    
    public void Subir(int subida)
    {
        Console.WriteLine("Subiendo");
        alturaCm += (byte) subida;
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
        //alturaCm = Convert.ToByte(alturaInicial);
        alturaCm = (byte) alturaInicial;
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
        Taburete tabureteDeRuben = new Taburete(73);
        //tabureteDeRuben.SetAltura(65);
        Console.WriteLine("La altura es " +
            tabureteDeRuben.GetAltura() );
        tabureteDeRuben.Subir();
        tabureteDeRuben.Subir(5);
        tabureteDeRuben.Bajar();
    }
}
