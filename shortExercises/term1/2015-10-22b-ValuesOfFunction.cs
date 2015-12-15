// Ruben Blanco
// Program: ValuesOfFunction

using System;

public class ValuesOfFunction
{
    public static void Main()
    {
        int x, y;
        
        for(x=-10; x<=10; x++)
        {
            y = x*x - 2*x + 1;
            Console.WriteLine("{0} {1}", x, y);
        }
    }
}
