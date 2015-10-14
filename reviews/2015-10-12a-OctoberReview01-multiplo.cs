/*  María Jesús Atalaya
    multi
*/
using System;
public class Mulplipli
{
    public static void Main()
    {
    
    Console.WriteLine("Enter number");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter number");
    int n2 = Convert.ToInt32(Console.ReadLine());

    if (n1 % n2 == 0)
        Console.WriteLine ("Es multiplo");
    else
        Console.WriteLine ("No es multiplo");
    }
}
