/*  María Jesús Atalaya
    contrasenya
*/

// Crea un programa que pida al usuario su contraseña (numérica). Deberá terminar 
// cuando introduzca como contraseña el número 1111, pero volvérsela a pedir 
// tantas veces como sea necesario. Debes usar "while".

using System;
public class Contrasenya
{
    public static void Main()
    {
    
        Console.WriteLine("Introduce tu password");
        int n1 = Convert.ToInt32(Console.ReadLine()); 

        while (n1 != 1111)
        {
            Console.WriteLine ("Error de password, intentalo otra vez");
            n1 = Convert.ToInt32(Console.ReadLine()); 
        }
        Console.WriteLine ("Correcto");
    }
}
