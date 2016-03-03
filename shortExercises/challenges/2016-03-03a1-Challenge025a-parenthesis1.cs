// David Gascon, Indra López, Vicente Cuenca

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
        int repes = Convert.ToInt32(Console.ReadLine());

        int countDer = 0;
        int countIzq = 0;

        for (int i = 0; i < repes;i++)
        {
            countDer = 0;
            countIzq = 0;

            string linea = Console.ReadLine();
            for (int j = 0; j < linea.Length; j ++)
            {
                if (linea[j] == '(')
                    countIzq ++;
                if (linea[j] == ')' && countIzq > 0)
                {
                    countDer ++;
                    countIzq --;
                }
            }
            Console.WriteLine(countDer * 2);
        }
    }
}
