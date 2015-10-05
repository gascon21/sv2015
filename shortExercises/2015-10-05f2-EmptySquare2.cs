// Indra Lopez Galvez
// My program used to draw the hollow square

using System;
public class HollowSquare{
    
    public static void Main(){
        
        int col, i, row, size;
        Console.WriteLine("How many do you want: ");
        size =Convert.ToInt32(Console.ReadLine());
        
        // First row
        for(col = 1; col <= size; col ++)
            Console.Write("*");            
        Console.WriteLine();
            
        // Middle rows
        for(row = 1; row <= size-2; row++)
        {
            Console.Write("*");
            for( i=1; i <= size-2; i++)
                Console.Write(" ");
            Console.WriteLine("*");
        }
        
        // Last row
        for(col = 1; col <= size; col ++)            
            Console.Write("*");            
        Console.WriteLine();
    }
}
