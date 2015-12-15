/*  Nombre: Jose Vicente Leal
 *  Number number positive
 *  24/09/2015
*/
using System;
public class numberpositive2
{
    public static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
            Console.WriteLine("It is not positive"); 
        else 
            Console.WriteLine("It is positive");          
    }
}
