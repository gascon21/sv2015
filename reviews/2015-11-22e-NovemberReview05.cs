/* 
Crea un array de enteros largos, formado por 8 datos que introduzca 
el  usuario. Después muestra los datos que sean pares. 
*/

using System;
public class ArrayLargopares
{
    public static void Main()
    {
        const int SIZE = 8;
        long[] datos = new long[SIZE];
        
        for (int i=0; i<SIZE; i++)
        {
            Console.Write("Introduce el dato {0}: ", i+1);
            datos[i] = Convert.ToInt64( Console.ReadLine() );
        }
        
        for (int i=0; i<SIZE; i++)
            if (datos[i] % 2 == 0)
                Console.Write("{0} ", datos[i]);
    }
}
    
