// Chen Chao
// 01-01-2016

using System;

public class Ejer05NavBasic
{
    public static void Main()
    {
        const byte WIDTH = 79;
        const byte HEIGHT = 23;
        const byte snowFlakes = 100;
        
        // First way:using an array
        char[,] buffer = new char[HEIGHT, WIDTH];
        
        for (byte row = 0; row < HEIGHT; row++)
            for (byte col = 0; col < WIDTH; col++)
                buffer[row,col] = ' ';

        Random random = new Random();
        
        for (byte i = 0; i < snowFlakes; i++)
        {
            int x = random.Next(0, WIDTH);
            int y = random.Next(0, HEIGHT);
            buffer[y, x] = '*';
        }
        
        for (byte row = 0; row < HEIGHT; row++)
        {
            for (byte col = 0; col < WIDTH; col++)
                Console.Write(buffer[row, col]);
            Console.WriteLine();
        }
        Console.ReadLine();
        
        // Second way: Console.XXX
        Console.Clear();
        for (byte i = 0; i < snowFlakes; i++)
        {
            int x = random.Next(0, WIDTH);
            int y = random.Next(0, HEIGHT);
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
        Console.ReadKey();
    }
}
