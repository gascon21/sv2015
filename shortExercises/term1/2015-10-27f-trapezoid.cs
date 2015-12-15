// Chen Chao
// Program: Trapezoid
// 27-10-2015

using System;

public class Trapezoid
{
    public static void Main()
    {
        Console.Write("Enter the desired width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        int spaces = 0;
        
        for (int i = 0; i < height; i++)
        {
            if (width >= 1)
            {
                for (int colspace = 0; colspace < spaces; colspace++)
                    Console.Write(" ");
                for (int colwidth = 0; colwidth < width; colwidth++)
                    Console.Write("*");
                    
                Console.WriteLine();
                width-=2;
                spaces++;
            }
        }
        
    }
}
