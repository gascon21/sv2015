// Sacha, Chen, Miguel

/*
Salida

Por cada caso de prueba, imprimirá 'SI' si el programa imprime 
cualquier texto por pantalla, 'NO' en caso contrario.

Ejemplo de entrada
3
4
O
L
A
K
4
OO
LO
AO
K
5
Op
Lp
Ap
Kp
Kp

Ejemplo de salida
SI
NO
SI
*/

using System;

public class Olak
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        bool imprimible = false;
        string line;
        int counter = 0;
        
        for (int i = 0; i < casos; i++)
        {
            int letras = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < letras; j++)
            {
                line = Console.ReadLine();
                for (int k = 0 ; k < line.Length; k++)
                    if (line[k] == 'O' || line[k] == 'L' || line[k] == 'A')
                        counter++;
                        
                if (counter == 1)
                    imprimible = true;
                    
                counter = 0;
            }
            if (imprimible )
                Console.WriteLine("SI");
            else
                Console.WriteLine("NO");
            imprimible = false;
            //counter = 0;
        }
    }
}
