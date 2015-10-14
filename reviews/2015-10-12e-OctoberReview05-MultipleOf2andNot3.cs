/*
* Carla Liarte Felipe
* Crea un programa que pida al usuario un número entero y responda si es
* múltiplo de 2 pero no de 3.
*/

using System;

public class Ejercicio5
{
    public static void Main()
    {
        int n1;
        Console.Write ("Escribe el numero: ");
        n1 = Convert.ToInt32(Console.ReadLine() );

        if ((n1 % 2 == 0) && (n1 % 3 != 0))
            Console.WriteLine("Es multiplo de 2 pero no 3");
        else 
            Console.WriteLine("No es multiplo de 2 o lo es de 3");
    }
}
