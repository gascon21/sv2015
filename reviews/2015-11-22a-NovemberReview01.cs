/* 
Crea un array de enteros que contenga los datos 10, 20, 25, 27. El 
usuario introducirá un número del 1 al 4 y se le mostrará el dato que 
está en esa posición (si introduce 1, se le responderá 10; si teclea 4, 
se le dirá 27).
*/

using System;
public class Arrayenteros
{
    public static void Main()
    {
       int[] datos = {10,20,25,27};
       
       Console.Write("Qué posición quieres ver? ");
       int pos = Convert.ToInt32 (Console.ReadLine());
       Console.Write( datos[pos+1] );
    }
}
