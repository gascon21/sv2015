/* Mónica Esteve Fernández
(2.2.3.5) Crea un programa que muestre los primeros ocho números pares: 
2 4 6 8 10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, 
o bien mostrar el doble del valor que hace de contador).
*/

using System;

public class ListEven
{
    public static void Main()
    {
        int i;
        int cont=1;
        
        for(i=2; i<=16; i +=2)
            Console.Write("{0} ", i);
        Console.WriteLine();
        
        //another way
        for ( i=1; cont<=8; i++)
            Console.WriteLine("{0} ",i*2);
        Console.WriteLine();
    }
}
