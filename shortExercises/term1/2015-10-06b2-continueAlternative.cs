/*
 * 
 * José miguel Leonis
 * 
 * From 1 to 100 minus user number
 */
using System;

public class ej40
{
    public static void Main()
    {
        int number1;
        
        Console.WriteLine("Enter a number please");
        number1 = Convert.ToInt32(Console.ReadLine());
        
        for (int i= 1; i<=100;i++)
        {
            if(i != number1) 
                Console.Write("{0} ", i);
        }
            
    }
}
