/*
* Carla Liarte Felipe
*  Crea un programa que pida al usuario un número entero y responda si es
* múltiplo de 2 o de 3.
*/

using System;

public class Ejercicio3
{
    public static void Main()
    {
        Console.Write ("Entra el numero :");
        int n1 = Convert.ToInt32 (Console.ReadLine() );

        if (n1 % 2 == 0)
            Console.WriteLine("Es multiplo de 2");
        if (n1 % 3 == 0)
            Console.WriteLine("Es multiplo de 3");
    }
}
