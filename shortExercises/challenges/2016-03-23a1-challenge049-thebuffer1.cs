// Challenge 049: The buffer
// Gonzalo García Soler

using System;

public class TheBuffer
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            long input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input % 2 == 0 ? input / 2 : (input / 2) + 1);
        }
    }
}
