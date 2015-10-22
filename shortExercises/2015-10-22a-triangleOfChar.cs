/*
 *José Miguel Leonis 
 * 
 * Char triangle
 */

using System;
public class CharTriangle
{
    public static void Main()
    {
        Console.WriteLine("Enter a size please: ");
        byte size = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("Enter a char please: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        
        int height = (size+1)/2;
        int chars = 1;
        if (size % 2 == 0)
            chars++;
        int spaces = height-1;
        for (int row = 0;row<height;row++)
        {
            for(int i =0;i<spaces;i++)
                Console.Write(" ");
            
            for(int j =0;j<chars;j++)
                Console.Write(symbol);
            
            Console.WriteLine();
            
            chars += 2;
            spaces --;
        }
        
        
    }
}
