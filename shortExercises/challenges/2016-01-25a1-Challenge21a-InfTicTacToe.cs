// Chen Chao
// 25-01-2016

using System;

public class TresEnRaya
{
    public static void Main()
    {
        byte pruebas = Convert.ToByte(Console.ReadLine());
        string[] lineas = new string[3];
        
        for (byte i = 0; i < pruebas; i++)
        {
            for (byte row = 0; row < lineas.Length; row++)
                lineas[row] = Console.ReadLine();
            
            if (lineas[1][1] == 'O')
                Console.WriteLine("CIRCULO");
            else if (lineas[1][1] == 'X')
                Console.WriteLine("CRUZ");
            else
                Console.WriteLine("IMPOSIBLE");
        }
    }
}
