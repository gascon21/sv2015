// Growing triangle

using System;
public class Square 
{
    public static void Main() 
    {

        Console.WriteLine("Size of the triangle? ");
        int size =Convert.ToInt32(Console.ReadLine());

        for(int row = 1; row <= size; row ++)
        {
            for(int col = 1; col <= row; col ++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
