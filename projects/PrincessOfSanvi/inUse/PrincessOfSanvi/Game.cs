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

        int x = 400;
        int y = 250;
        int playerWidth = 50;
        int playerHeight = 107;
        int speed = 3;

        int birdX = 500;
        int birdY = 150;
        int birdWidth = 48;
        int birdHeight = 48;
        int birdSpeed = -2;
        int frame = 1;
        int finished = 0;

        // Game Loop
        while (finished == 0)
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
                frame = (frame + 1) % 10;
                x += speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_LEFT)
                    && (x > 0))
            {
                frame = (frame + 1) % 10;
                x -= speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_UP)
                    && (y > 0))
            {
                frame = (frame + 1) % 10;
                y -= speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_DOWN)
                    && (y < screenHeight-playerHeight))
            {
                frame = (frame + 1) % 10;
                y += speed;
            }

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = 1;

            // Move other elements
            if ((birdX > screenWidth-birdWidth) || (birdX < 0))
                birdSpeed = -birdSpeed;

            birdX = birdX + birdSpeed;

            // Check collisions and game state
            if ((birdX > x-birdWidth)
                    && (birdX < x+playerWidth)
                    && (birdY > y-birdHeight)
                    && (birdY < y+playerHeight))
                finished = 1;

            // Pause till next frame (50fps)
            Hardware.Pause(20);
        }
    }
}
