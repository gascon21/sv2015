// Chen Chao
// Square2
// 05-10-2015

using System;

public class Square
{
    public static void Main()
    {
        Console.Write("Enter the size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 1; row <= size; row++)
        {
            for (int col = 1; col <= size; col++)
            {
                if (row == 1 || row == size 
                        || col ==1 || col == size)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
