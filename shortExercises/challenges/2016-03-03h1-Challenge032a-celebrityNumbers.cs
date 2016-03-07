// "Celebrity" numbers
// David Gascon, Indra López, Vicente Cuenca

/*
Ejemplo de entrada
1
6
100
10
1
201
111
2

Ejemplo de salida
2 1 3

Ejemplo de entrada
2
3
1
2
3
4
1
2
3
4

Ejemplo de salida
1 1 1
1 2 1
*/
using System;

public class Celebrities
{
    public static void Main()
    {
        int repes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < repes; i++)
        {
            int casos = Convert.ToInt32(Console.ReadLine());
            string[] numeros = new string[casos];
            int[] numerosN = new int[casos];
            int max = 0;
            int min = 100000;
            int celebritis = 0;
            int normales = 0;
            int impopular = 0;


            for (int j = 0; j < casos; j++)
            {
                numeros[j] = Console.ReadLine();
                int num = 0;

                for (int k = 0; k < numeros[j].Length; k++)
                {
                    num += Convert.ToInt32(numeros[j][k] - 48);
                }
                numerosN[j] = num;

                if (num >= max)
                    max = num;
                if (num < min)
                    min = num;
            }
            for (int j = 0; j < numerosN.Length; j++)
            {
                if (numerosN[j] == max)
                    celebritis++;
                else if (numerosN[j] == min)
                    impopular++;
                else
                    normales++;
            }
            Console.WriteLine(celebritis + " " + normales+ " " + impopular);
        }
    }
}
