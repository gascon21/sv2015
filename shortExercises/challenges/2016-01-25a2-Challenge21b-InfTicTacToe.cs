// Jorge Montalvo Blanes
// 

using System;

public class Challenge020
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < cases; i++)
        {
            Console.ReadLine();
            string tablero1 = Console.ReadLine();
            Console.ReadLine();
            
            if(tablero1[1] == '-')
                Console.WriteLine("IMPOSIBLE");
            else if(tablero1[1] == 'O')
                Console.WriteLine("CIRCULO");
            else if(tablero1[1] == 'X')
                Console.WriteLine("CRUZ");
        }
    }
}

