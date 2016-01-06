// Program: December 28th

using System;

public class December28
{    
    public static void Main()
    {
        int rows = 4;
        int cols = 4;
        
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        string spaces = new String ( ' ', name.Length );
        
        for (int row = 1; row <= rows; row++)
        {
            for (int col = 1; col <= cols; col++)
            {
                if (row == 1 || row == rows 
                        || col ==1 || col == cols)
                    Console.Write(name);
                else
                    Console.Write(spaces);
            }
            Console.WriteLine();
        }
    }
}
