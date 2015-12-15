// Ruben Blanco
// Program: DisplayFunction

using System;

public class DisplayFunction
{
    public static void Main()
    {
        int x, y;
        
        int startPoint = -7;
        int endPoint = 8;
        
        for(x=startPoint; x<=endPoint; x++)
        {
            y = x*x - 2*x + 1;
            for (int i=0; i<y; i++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
