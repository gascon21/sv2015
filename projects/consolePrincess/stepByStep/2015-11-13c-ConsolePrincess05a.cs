/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

// Changes:
// Version 0.05a : Structs
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
        
    struct Image
    {
        public char symbol;
        public char symbol2;
        public ConsoleColor color;
    }
    
    struct Sprite
    {
        public byte x;
        public byte y;
        public sbyte horSpeed;
        public sbyte vertSpeed;
        public Image image;
    }


    public static void Main()
    {
        const byte SIZE = 5;
        Sprite player;
        Sprite[] bird = new Sprite[SIZE];

        
        player.image.color = ConsoleColor.Red;
        player.image.symbol = 'A';
        player.image.symbol2 = 'À';
        player.x = 40;
        player.y = 12;
        bird[0].image.color = ConsoleColor.Yellow;
        bird[0].image.symbol = 'W';
        bird[0].x = 20;
        bird[0].y = 5;
        bird[0].horSpeed = 1;
        bird[0].vertSpeed = 1;
        bird[1].image.color = ConsoleColor.Green;
        bird[1].image.symbol = 'W';
        bird[1].x = 30;
        bird[1].y = 7;
        bird[1].horSpeed = -1;
        bird[1].vertSpeed = -1;
        bird[2].image.color = ConsoleColor.Blue;
        bird[2].image.symbol = 'W';
        bird[2].x = 40;
        bird[2].y = 9;
        bird[2].horSpeed = 1;
        bird[2].vertSpeed = 1;
        bird[3].image.color = ConsoleColor.Yellow;
        bird[3].image.symbol = 'W';
        bird[3].x = 60;
        bird[3].y = 13;
        bird[3].horSpeed = -1;
        bird[3].vertSpeed = -1;
        bird[4].image.color = ConsoleColor.White;
        bird[4].image.symbol = 'W';
        bird[4].x = 15;
        bird[4].y = 19;
        bird[4].horSpeed = -1;
        bird[4].vertSpeed = -1;
        
        ConsoleKeyInfo key;
        bool finished = false;
        byte frame = 1;

        while ( ! finished )
        {
            // Draw elements on screen
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = player.image.color;
            Console.SetCursorPosition(player.x,player.y);
            if (frame == 1)
                Console.WriteLine(player.image.symbol);  // Player
            else
                Console.WriteLine(player.image.symbol2);
            
            
            for(int i=0; i<5; i++)
            {
                Console.ForegroundColor = bird[i].image.color;
                Console.SetCursorPosition(bird[i].x,bird[i].y);
                Console.WriteLine(bird[i].image.symbol);  // Bird
            }

            // Check keys and move player
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
                        && (player.x > 0))
                {
                    frame = (byte) ((frame + 1) % 2);
                    player.x--;
                }

                if (((key.KeyChar == '6')  || (key.Key == ConsoleKey.RightArrow))
                        && (player.x < 79))
                {
                    frame = (byte) ((frame + 1) % 2);
                    player.x++;
                }

                if (((key.KeyChar == '8')  || (key.Key == ConsoleKey.UpArrow))
                        && (player.y > 0))
                {
                    frame = (byte) ((frame + 1) % 2);
                    player.y--;
                }

                if (((key.KeyChar == '2')  || (key.Key == ConsoleKey.DownArrow))
                        && (player.y < 24))
                {
                    frame = (byte) ((frame + 1) % 2);
                    player.y++;
                }
                    
                if (key.Key == ConsoleKey.Escape)
                    finished = true;
            }
                
            // Move other elements
            for(int i=0; i<5; i++)
            {
                if ((bird[i].x == 79) || (bird[i].x == 0) || (bird[i].y == 24)
                    || (bird[i].y == 0))
                {
                    bird[i].horSpeed = (sbyte) -bird[i].horSpeed;
                    bird[i].vertSpeed = (sbyte) -bird[i].vertSpeed;
                }
            }
                
            for(int i=0; i<5; i++)
            {
                bird[i].x = (byte) (bird[i].x + bird[i].horSpeed);
                bird[i].y = (byte) (bird[i].y + bird[i].vertSpeed);
            }
            
            // Check collisions and game state
            for(int i=0; i<5; i++)
                if ((bird[i].x == player.x) && (bird[i].y == player.y))
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
