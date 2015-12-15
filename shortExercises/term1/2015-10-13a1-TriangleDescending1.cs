// Jorge Montalvo Blanes
// triangle descending

using System;

public class TriangleDscending
{
    public static void Main()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        for(int row = size; row >= 1 ;row--)
        {
            for(int column = 1; column <= row; column ++)
                Console.Write("*");
                
            Console.WriteLine();
        }
    }
}
