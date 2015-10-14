/*
* Carla Liarte Felipe
* Crea un programa que pida al usuario un número entero y responda si es
* múltiplo de 2 y de 3 simultáneamente.
*/

using System;

public class Ejercicio4
{
    public static void Main()
    {
        Console.Write ("Entra el numero :");
        int n1 = Convert.ToInt32 (Console.ReadLine() );

        if (n1 % 2 == 0 && n1 % 3 == 0)
            Console.WriteLine("Es multiplo de 2 y de 3");
        else
            Console.WriteLine("No es multiplo de y de 3 a la vez");
    }
}
