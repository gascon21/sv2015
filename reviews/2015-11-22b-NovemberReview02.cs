/*  
Crea un array de enteros que contenga los datos 10, 20, 25, 27. 
Muestra  su contenido del primer elemento al último y luego del 
último elemento al primero, usando dos bucles "for"
*/
using System;
public class MostrarArray
{
    public static void Main()
    {
        int[] datos ={10,20,25,27};
        for (int i=0; i<4; i++)
            Console.Write( "{0} ", datos[i] );
        Console.WriteLine();        
        
        for (int i=3; i>=0; i--)
            Console.Write( "{0} ", datos[i] );
        Console.WriteLine();
    }
}
