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

        float[] birdX = { 500, 200, 150, 600, 100 };
        float[] birdY = { 150, 200, 300, 400, 520 };
        ushort birdWidth = 48;
        ushort birdHeight = 48;
        float[] birdSpeed = { -2.8f, 1.4f, 3.2f, -1.2f, 2.0f };
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
            for (int i = 0; i < 5; i++)
                Hardware.DrawHiddenImage(bird, 
                    (short) birdX[i], (short) birdY[i]);
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
            for (int i = 0; i < 5; i++)
            {
                if ((birdX[i] > screenWidth - birdWidth) || (birdX[i] < 0))
                    birdSpeed[i] = -birdSpeed[i];
                birdX[i] = (short)(birdX[i] + birdSpeed[i]);
            }

            // Check collisions and game state
            for (int i = 0; i < 5; i++)
                if ((birdX[i] > x-birdWidth)
                    && (birdX[i] < x+playerWidth)
                    && (birdY[i] > y-birdHeight)
                    && (birdY[i] < y+playerHeight))
                finished = true;

            // Pause till next frame (50fps)
            Hardware.Pause(20);
        }
    }
}
