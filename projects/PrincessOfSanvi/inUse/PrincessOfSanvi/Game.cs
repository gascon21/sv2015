/*
  First skeleton for a simple graphic game
  Version A (based on console version 0.02: 
  draw an image on screen and move it, until ESC)
*/

using System;

public class Game
{
    public static void Main()
    {
        bool fullScreen = false;
        short screenWidth = 800;
        short screenHeight = 600;
        Hardware.Init(screenWidth, screenHeight, 24, fullScreen);
        Image player = new Image("data\\player.bmp");
        Image player2 = new Image("data\\player2.bmp");
        Image bird = new Image("data\\bird.bmp");

        short x = 400;
        short y = 250;
        ushort playerWidth = 50;
        ushort playerHeight = 107;
        float speed = 3.8f;

        short birdX = 500;
        short birdY = 150;
        ushort birdWidth = 48;
        ushort birdHeight = 48;
        float birdSpeed = -2.8f;
        byte frame = 1;
        bool finished = false;

        // Game Loop
        while (! finished)
        {
            // Draw elements on screen
            Hardware.ClearScreen();
            if (frame < 5)
                Hardware.DrawHiddenImage(player, x, y);
            else
                Hardware.DrawHiddenImage(player2, x, y);
            Hardware.DrawHiddenImage(bird, birdX, birdY);
            Hardware.ShowHiddenScreen();

            // Check keys and move player
            if (Hardware.KeyPressed(Hardware.KEY_RIGHT)
                    && (x < screenWidth-playerWidth))
            {
                frame = (byte) ((frame + 1) % 10);
                x +=(short) speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_LEFT)
                    && (x > 0))
            {
                frame = (byte)((frame + 1) % 10);
                x -= (short) speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_UP)
                    && (y > 0))
            {
                frame = (byte)((frame + 1) % 10);
                y -= (short) speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_DOWN)
                    && (y < screenHeight-playerHeight))
            {
                frame = (byte)((frame + 1) % 10);
                y += (short) speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = true;

            // Move other elements
            if ((birdX > screenWidth-birdWidth) || (birdX < 0))
                birdSpeed = -birdSpeed;

            birdX = (short)(birdX + birdSpeed);

            // Check collisions and game state
            if ((birdX > x-birdWidth)
                    && (birdX < x+playerWidth)
                    && (birdY > y-birdHeight)
                    && (birdY < y+playerHeight))
                finished = true;

            // Pause till next frame (50fps)
            Hardware.Pause(20);
        }
    }
}
