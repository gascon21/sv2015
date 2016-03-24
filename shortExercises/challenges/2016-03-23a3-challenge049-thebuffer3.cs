// Challenge 049: The buffer
// Gonzalo García Soler, improved by Nacho

using System;

public class TheBuffer
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            long input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( (input + 1) / 2 );
        }
    }
}
