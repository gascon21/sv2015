/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

using System;

public class ConsolePrincess
{
    public static void Main()
    {
        int x = 40;
        int y = 12;
        int birdX = 20;
        int birdY = 5;
        int birdSpeed = 1;
        ConsoleKeyInfo key;
        int finished = 0;

        while ( finished == 0 )
        {
            // Draw elements on screen
            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.WriteLine("A");  // Player
            Console.SetCursorPosition(birdX,birdY);
            Console.WriteLine("W");  // Bird

            // Check keys and move player
            key = Console.ReadKey();
            if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
                    && (x > 0))
                x = x-1;

            if (((key.KeyChar == '6')  || (key.Key == ConsoleKey.RightArrow))
                    && (x < 79))
                x = x+1;

            if (((key.KeyChar == '8')  || (key.Key == ConsoleKey.UpArrow))
                    && (y > 0))
                y = y-1;

            if (((key.KeyChar == '2')  || (key.Key == ConsoleKey.DownArrow))
                    && (y < 24))
                y = y+1;
                
            if (key.Key == ConsoleKey.Escape)
                finished = 1;
                
            // Move other elements
            if (birdX == 79)
                birdSpeed = -1;
            if (birdX == 0)
                birdSpeed = 1;
            //if ((birdX == 79) || (birdX == 0))
            //    birdSpeed = -birdSpeed;
                
            birdX = birdX + birdSpeed;
        }
    }
}

