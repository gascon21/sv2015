/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

// Changes:
// Version 0.04b : Several birds, second approach: parallel arrays
// Version 0.04a : Several birds, first approach: variables x 3
// Version 0.03g : Optimized data types
// Version 0.03f : Example of usage of "bool"
// Version 0.03e : Two differents "images"
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
        byte x = 40;
        byte y = 12;
        byte[] birdX = { 20, 30, 40, 60, 15};
        byte[] birdY = { 5, 7, 9, 13, 19};
        sbyte[] birdSpeed = {1, -1, 1, -1, -1};
        ConsoleKeyInfo key;
        bool finished = false;
        byte frame = 1;

        // while ( finished == false )
        // while ( finished != true )
        while ( ! finished )
        {
            // Draw elements on screen
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x,y);
            if (frame == 1)
                Console.WriteLine("A");  // Player
            else
                Console.WriteLine("À");
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            for(int i=0; i<5; i++)
            {
                Console.SetCursorPosition(birdX[i],birdY[i]);
                Console.WriteLine("W");  // Bird
            }

            // Check keys and move player
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
                        && (x > 0))
                {
                    //frame = frame == 1 ? 0 : 1;
                    frame = (byte) ((frame + 1) % 2);
                    x--;
                }

                if (((key.KeyChar == '6')  || (key.Key == ConsoleKey.RightArrow))
                        && (x < 79))
                {
                    frame = (byte) ((frame + 1) % 2);
                    x++;
                }

                if (((key.KeyChar == '8')  || (key.Key == ConsoleKey.UpArrow))
                        && (y > 0))
                {
                    frame = (byte) ((frame + 1) % 2);
                    y--;
                }

                if (((key.KeyChar == '2')  || (key.Key == ConsoleKey.DownArrow))
                        && (y < 24))
                {
                    frame = (byte) ((frame + 1) % 2);
                    y++;
                }
                    
                if (key.Key == ConsoleKey.Escape)
                    finished = true;
            }
                
            // Move other elements
            for(int i=0; i<5; i++)
            {
                if ((birdX[i] == 79) || (birdX[i] == 0))
                    birdSpeed[i] = (sbyte) -birdSpeed[i];
            }
                
            for(int i=0; i<5; i++)
                birdX[i] = (byte) (birdX[i] + birdSpeed[i]);
            
            // Check collisions and game state
            for(int i=0; i<5; i++)
                if ((birdX[i] == x) && (birdY[i] == y))
                    finished = true;
            
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
