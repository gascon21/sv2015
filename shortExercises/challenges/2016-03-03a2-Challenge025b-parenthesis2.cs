// Nacho

/*
Para cada caso de prueba, escribir una línea indicando la longitud 
máxima posible de un paréntesis equilibrado que haya podido obtenerse 
de la secuencia de paréntesis, ya sea tal como está o eliminando los 
paréntesis que sean necesarios. En caso de no poderse obtener una 
secuencia de paréntesis equilibrados, el resultado será 0.

Ejemplo de entrada
4
(()))(
((()())
()
(
Ejemplo de salida
4
6
2
0
*/

using System;
using System.Collections;

public class Parenthesis
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < casos;i++)
        {
            int cantidad = 0;
            string linea = Console.ReadLine();
            while (linea.Contains("()"))
            {
                linea = linea.Remove( linea.IndexOf("()"), 2 );
                cantidad += 2;
            }
            Console.WriteLine(cantidad);
        }
    }
}
