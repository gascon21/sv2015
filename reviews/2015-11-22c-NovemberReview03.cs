/*  
Crea un array de enteros que contenga los datos 10, 20, 25, 27. El 
usuario introducirá un número y se le responderá si aparece en el 
array o no. Por ejemplo, si introduce 20 se le dirá que sí aparece en 
el array, mientras que si introduce 30, se le responderá que no 
aparece.
*/

using System;
public class MostrarArray
{
    public static void Main()
    {
        int[] datos ={10,20,25,27};
        
        Console.WriteLine ("Introduce un número");
        int num = Convert.ToInt32 (Console.ReadLine());
        
        bool encontrado = false;
        for (int i=0; i<4; i++)
            if (num == datos[i])
                encontrado = true;
                
        if (encontrado)
                Console.Write ("Sí está");
        else
            Console.WriteLine("No está");       
    }
}
    
