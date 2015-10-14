using System;
public class ej2132
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter a number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        if(n2 != 0)
            Console.WriteLine("{0}/{1}={2}",n1,n2,n1/n2);
        else
            Console.WriteLine("Error: can't divide by zero");
    }
}
