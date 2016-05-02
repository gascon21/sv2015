// Persistencia 01
// Acercamiento a la persistencia

using System;
using System.IO;

public class Persist01
{

    int numero;

    public void SetNumero(int n)
    {
        numero = n;
    }

    public int GetNumero()
    {
        return numero;
    }

    public void Guardar(string nombre)
    {
        BinaryWriter ficheroSalida = new BinaryWriter(
            File.Open(nombre, FileMode.Create));
        ficheroSalida.Write(numero);
        ficheroSalida.Close();
    }

    public void Cargar(string nombre)
    {
        BinaryReader ficheroEntrada = new BinaryReader(
            File.Open(nombre, FileMode.Open));
        numero = ficheroEntrada.ReadInt32();
        ficheroEntrada.Close();
    }


    public static void Main()
    {
        Persist01 ejemplo = new Persist01();
        ejemplo.SetNumero(5);
        Console.WriteLine("Valor: {0}", ejemplo.GetNumero());
        ejemplo.Guardar( "persist01.dat" );

        Persist01 ejemplo2 = new Persist01();
        Console.WriteLine("Valor 2: {0}", ejemplo2.GetNumero());

        ejemplo2.Cargar( "persist01.dat" );
        Console.WriteLine("Y ahora: {0}", ejemplo2.GetNumero());
    }
}
