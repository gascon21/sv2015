/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

// Changes:
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
        
        byte birdX = 20;
        byte birdY = 5;
        sbyte birdSpeed = 1;
        
        byte birdX2 = 12;
        byte birdY2 = 9;
        sbyte birdSpeed2 = -1;
        
        byte birdX3 = 45;
        byte birdY3 = 15;
        sbyte birdSpeed3 = 1;
        
        ConsoleKeyInfo key;
        bool finished = false;
        byte frame = 1;

        // while ( finished == false )
        // while ( finished != true )
        while ( ! finished )
        {
            // Draw elements on screen
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x,y);
            if (frame == 1)
                Console.WriteLine("A");  // Player
            else
                Console.WriteLine("À");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(birdX,birdY);
            Console.WriteLine("W");  // Birds
            Console.SetCursorPosition(birdX2,birdY2);
            Console.WriteLine("W");
            Console.SetCursorPosition(birdX3,birdY3);
            Console.WriteLine("W");

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
            if ((birdX == 79) || (birdX == 0))
                birdSpeed = (sbyte) -birdSpeed;
            if ((birdX2 == 79) || (birdX2 == 0))
                birdSpeed2 = (sbyte) -birdSpeed2;
            if ((birdX3 == 79) || (birdX3 == 0))
                birdSpeed3 = (sbyte) -birdSpeed3;
                
            birdX = (byte) (birdX + birdSpeed);
            birdX2 = (byte) (birdX2 + birdSpeed2);
            birdX3 = (byte) (birdX3 + birdSpeed3);
            
            // Check collisions and game state
            if ((birdX == x) && (birdY == y))
                finished = true;
            if ((birdX2 == x) && (birdY2 == y))
                finished = true;
            if ((birdX3 == x) && (birdY3 == y))
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
