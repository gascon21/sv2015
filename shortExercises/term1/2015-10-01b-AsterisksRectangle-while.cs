// Rectangle

using System;

public class Rectangle
{
    public static void Main()
    {
        Console.Write("Width: ");
        int width = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Height: ");
        int height = Convert.ToInt32( Console.ReadLine() );
        
        int row=1;
        
        while (row <= height)
        {
            int column=1;
            while( column <= width )
            {
                Console.Write("*");
                column=column+1;
            }
            Console.WriteLine();
            
            row = row + 1;
        }
    }
}
