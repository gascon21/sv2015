// IsInteger

using System;

public class FibonacciRecursive
{
    public static int Fibonacci( int term )
    {
        if (term == 0) return 0;
        if (term == 1) return 1;
        
        return Fibonacci( term-1 ) +
            Fibonacci( term-2 );
    }
    
    public static void Main()
    {
        for (int i=0; i<=10; i++)
            Console.WriteLine("{0} => {1}",
                i, Fibonacci(i));
    }
}
