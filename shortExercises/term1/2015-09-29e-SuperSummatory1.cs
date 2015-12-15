/*
 * Jose Manuel Mas 1DAM
 * Super Adder
 */

using System;

public class SuperAdder
{
    public static void Main()
    {
        int n1,n2,sum;
        
        Console.WriteLine("Add 2 numbers");
        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter a number: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        while (n1 != 0 || n2 != 0)
        {
            sum= n1 + n2;
            Console.WriteLine("Result: {0} + {1} = {2}",n1,n2,sum);
            
            Console.Write("Enter a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter a number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Bye!");
    }
}
