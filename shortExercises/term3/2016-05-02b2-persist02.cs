// Persistencia 02
// Ejemplo básico de persistencia

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Persist02
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

    // Métodos para guardar en fichero y leer desde él

    public static void Guardar(string nombre, Persist02 objeto)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream(nombre,
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, objeto);
        stream.Close();
    }

    public static Persist02 Cargar(string nombre)
    {
        Persist02 objeto;
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream(nombre, 
            FileMode.Open, FileAccess.Read, FileShare.Read);
        objeto = (Persist02)formatter.Deserialize(stream);
        stream.Close();
        return objeto;
    }
    
    // Y "Main" de prueba

    public static void Main()
    {
        Persist02 ejemplo = new Persist02();
        ejemplo.SetNumero(5);
        Console.WriteLine("Valor: {0}", ejemplo.GetNumero());
        Guardar("persist02.dat", ejemplo);

        Persist02 ejemplo2 = new Persist02();
        Console.WriteLine("Valor 2: {0}", ejemplo2.GetNumero());
        ejemplo2 = Cargar("persist02.dat");
        Console.WriteLine("Y ahora: {0}", ejemplo2.GetNumero());
    }
}
