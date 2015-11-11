/*  María Jesús Atalaya

Create a program that asks the user for a string and displays a 
right-aligned triangle:

____o
___ho
__cho
_acho
Nacho

*/
using System;
public class Cadenas
{
    public static void Main()
    {
        string name;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        
        for (int i = 1 ; i <= name.Length ; i++)
        {
            for (int spaces = 1; spaces <= name.Length-i; spaces++)
            {
                Console.Write("_");
            }
            Console.WriteLine(name.Substring(name.Length-i,i));
        }
    } 
}
