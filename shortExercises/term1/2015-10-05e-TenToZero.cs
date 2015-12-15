// Chen Chao
// Sequence
// 05-10-2015

using System;

public class Sequence
{
    public static void Main()
    {
        for (int row = 1; row <= 11; row++)
        {
            for (int i = 10; i >= 0; i-=2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
