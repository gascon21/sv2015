/*
* Pablo Padilla Martinez
* Create a function named "IsPrime", which receives an integer number and 
* retuns true if it is prime, or false if it is not:
* if (IsPrime(127)) ...
*/

using System;

public class greeting
{
    public static bool IsPrime(int n)
    { 
        int dividers = 0;
        int i=1;
        while ((i<= n) && (dividers <= 2))
        {
            if (n % i == 0)
                dividers++;
            i++;
        }
        
        if (dividers == 2)
            return true;
        else
            return false;
    }
    
    public static void Main()
    {  
        Console.WriteLine("Insert number to check if is prime: ");
        int number=Convert.ToInt32(Console.ReadLine());
        
        if(IsPrime(number))
        {
            Console.WriteLine("It is a primer number!");
        }
        else
            Console.WriteLine("It is not a primer number!");
    }
}
