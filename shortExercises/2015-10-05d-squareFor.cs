// Square!

using System;
public class Square 
{
    public static void Main() 
    {

        Console.WriteLine("Size of the square? ");
        int size =Convert.ToInt32(Console.ReadLine());

        for(int row = 1; row <= size; row ++)
        {
            for(int col = 1; col <= size; col ++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
