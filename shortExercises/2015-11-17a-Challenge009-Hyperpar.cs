// David Gascón López
// Challenge 009
/*
Se dice que un número es hyperpar cuando todos sus dígitos son pares. 
¿Sabes identificarlos?

Entrada
La entrada consta de una serie de casos de prueba. Cada uno está 
compuesto de una única línea con un número no negativo ni mayor que 
10^9.
Los casos de prueba terminan con un número negativo que no habrá que procesar.

Salida
Para cada caso de prueba se escribirá, en una línea independiente, "SI" 
si el número es hyperpar y "NO" si no lo es.

Entrada de ejemplo
2460
1234
2
-1

Salida de ejemplo
SI
NO
SI

https://www.aceptaelreto.com/problem/statement.php?id=165
*/

using System;
public class Challenge009
{
    public static void Main()
    {
        string num;
        do
        {
            bool hyperpar = true;
            num = Console.ReadLine();
            
            if(num[1] != '-')
            {
                for(int i = 0 ; i < num.Length ; i ++)
                    if(num[i] % 2 != 0)
                        hyperpar = false;
                if(hyperpar)
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");
            }
        }
        while(num[1] != '-');
    }   
}
