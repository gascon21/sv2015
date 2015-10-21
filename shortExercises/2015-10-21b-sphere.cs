/*  Name: Jose Vicente Leal
 *  Program: sphere
 *  21/10/2015
*/
using System;
public class sphere
{
    public static void Main()
    {
        
        float radius;
        float pi = 3.141592f;

        Console.Write("Enter radius:");
        radius = Convert.ToSingle(Console.ReadLine());
        
        float area = 4*pi*radius*radius;
        float volume = (4.0f/3)*pi*radius*radius*radius;
        Console.WriteLine("Surface: {0}",area);
        Console.WriteLine("Volume: {0}",volume);

    }
}
