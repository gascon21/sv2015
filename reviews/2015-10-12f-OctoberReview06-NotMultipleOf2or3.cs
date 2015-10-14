/*
* Carla Liarte Felipe
*  Crea un programa que pida al usuario un número entero y responda si no es
* múltiplo de 2 ni de 3.
*/

using System;

public class Ejercicio6
{
    public static void Main()
    {
        int n1;
        Console.Write ("Introduce el numero: ");
        n1 = Convert.ToInt32 (Console.ReadLine() );

        if (! ((n1 % 2 == 0) || (n1 % 3 ==0)))
            Console.WriteLine("No es multiplo ni de 2 ni de 3");
        else
            Console.WriteLine("Es multiplo de 2 o de 3");
    }
}
