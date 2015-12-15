// Chen Chao
// Triangle descending
// 13-10-2015

using System;

public class TriangleDescending
{
    public static void Main()
    {
        Console.Write("Enter the desired size of the triangle: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int width = size;
        
        for (int row = 1; row <= size; row++)
        {
            for (int col = 1; col <= width; col++)
                Console.Write("*");
            width--;
            Console.WriteLine();
        }
    }
}
