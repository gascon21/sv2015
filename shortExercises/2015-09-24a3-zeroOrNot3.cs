// Pedro Antonio Pérez Paterna
// The program indicates if the number is zero or not.
using System;
public class ZeroOrNot2
{
    public static void Main()
    {
        int n;
        
        Console.WriteLine("Enter a number");
        n = Convert.ToInt32(Console.ReadLine());
        
        // Less efficient than using "else"
        
        if ( n != 0 )
            Console.WriteLine("It's not zero");
        
        if ( n == 0 )
            Console.WriteLine("It's zero");
    }
}
