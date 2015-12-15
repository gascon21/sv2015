// Triangle descending (right-aligned)
// 13-10-2015

using System;

public class TriangleDescendingRight
{
    public static void Main()
    {
        Console.Write("Enter the desired size of the triangle: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int asterisks = size;
        int spaces = 0;
        
        for (int row = 1; row <= size; row++)
        {
            for (int col = 1; col <= spaces; col++)
                Console.Write(" ");
            spaces++;
            
            for (int col = 1; col <= asterisks; col++)
                Console.Write("*");
            asterisks--;
            
            Console.WriteLine();
        }
    }
}
