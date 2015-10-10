// Ruben Blanco
// Program: Multiplication of 2 numbers

using System;

public class SeptemberReview5
{
    public static void Main()
    {
        int number1, number2, mult ;
        Console.Write("Enter 1st number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter 2nd number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        mult = number1 * number2;
        Console.WriteLine("{0} * {1} = {2}", number1, number2, mult);
    }
}
