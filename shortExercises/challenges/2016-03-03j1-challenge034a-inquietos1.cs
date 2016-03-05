// Jorge Montalvo Blanes, Carla Liarte , Jose Manuel Mas

/*
Salida

Para cada caso de prueba, escribir una línea indicando el mayor número 
inquieto que divide a N con resto 0 o el texto 'IMPOSIBLE' si no existe 
ningún número inquieto que divida a N.

Ejemplo de entrada
4
2
8
10
348

Ejemplo de salida
IMPOSIBLE
8
5
58
*/

using System;

public class cerdas
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int [] num = {5,8,55,58,85,88,555,558,585,855,858,885,888,5555,
            5558,5585,5588,5855,5858,5885,5888,8555,8558,8585,8588,8855,8858,
            8885,8888};
        bool f = false;
        
        for(int i = 0; i < n; i++)
        {
            int res = 0;
            int n1 = Convert.ToInt32(Console.ReadLine());
            for(int j = 0; j < num.Length; j++)
            {
                if(n1 == 10)
                {
                    f = true;
                    res = 5;
                }
                
                else if(n1 % num[i] == 0)
                {
                    f = true;
                    res = num[i];
                }
            }
            if(f == true)
                Console.WriteLine(res);
            else
            {
                Console.WriteLine("IMPOSIBLE");
            }
        }
    }
}
