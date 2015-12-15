/* Juan Salinas Gómez
 * across the street
 * 12/10/2015
 */

using System;

public class AcrossStreet
{
    public static void Main()
    {
        int number;
        
        do
        {
            number = Convert.ToInt32(Console.ReadLine());
            
            if (number != 0)
            {
                if(number % 2 == 0)
                    Console.WriteLine("DERECHA");
                    
                else
                    Console.WriteLine("IZQUIERDA");
            }
        }
        while(number != 0);
    }
}
