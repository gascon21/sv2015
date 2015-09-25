/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

// Changes:
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

public class ConsolePrincess
{
    public static void Main()
    {
        int x = 40;
        int y = 12;
        ConsoleKeyInfo key;

        while ( 3 > 2 )  // Always
        {
            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.WriteLine("A");

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
        }
    }
}
