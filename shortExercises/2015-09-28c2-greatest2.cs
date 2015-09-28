/*
 * Pablo Padilla Martinez
 * Enter 2 numbers and said the gratest
 */
using System;
public class GreatestNumber
{
    public static void Main()
    {
        int number1, number2, max;
        
        Console.Write("Enter a number: ");
        number1=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter a number: ");
        number2=Convert.ToInt32(Console.ReadLine());
        
        if(number1>number2)
            max = number1;
        else
            max = number2;
            
        Console.WriteLine("The greatest is: {0}",max);
    }
}

