/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

// Changes:
// Version 0.03d : Colors!
// Version 0.03c : Check collisions and game state - end if bird is hit
// Version 0.03b : A moving element (second approach: independent)
// Version 0.03a : A moving element (first approach: when a key is pressed)
// Version 0.02d : Esc key to finish
// Version 0.02c : Two sets of keys (second approach: cursor keys)
// Version 0.02b : Two sets of keys (first approach: 2468 + WASD)
// Version 0.02a : No need to press Return
// Version 0.01j : Checking screen limits (v2)
// Version 0.01i : Checking screen limits
// Version 0.01h : Moving in four directions
// Version 0.01g : Clear screen before "drawing each frame"
// Version 0.01f : Allow to move several times, pressing 4 (+Return)
// Version 0.01e : Check if user pressed 4 (+Return) to move left
// Version 0.01d : Read input from the user
// Version 0.01c : Variables, using System
// Version 0.01b : Display text centered on screen (80 cosl, 25 rows)
// Version 0.01a : Just display some text on screen

using System;
using System.Threading;

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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x,y);
            Console.WriteLine("A");  // Player
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(birdX,birdY);
            Console.WriteLine("W");  // Bird

            // Check keys and move player
            if (Console.KeyAvailable)
            {
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
            }
                
            // Move other elements
            if (birdX == 79)
                birdSpeed = -1;
            if (birdX == 0)
                birdSpeed = 1;
                
            //if ((birdX == 79) || (birdX == 0))
            //    birdSpeed = -birdSpeed;
                
            birdX = birdX + birdSpeed;
            
            // Check collisions and game state
            if ((birdX == x) && (birdY == y))
                finished = 1;
            
            // Pause till next frame (10fps)
            Thread.Sleep(100);
        }
        Console.Clear();
        Console.SetCursorPosition(35,12);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Game Over!");
        
        Console.SetCursorPosition(1,18);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }
}
