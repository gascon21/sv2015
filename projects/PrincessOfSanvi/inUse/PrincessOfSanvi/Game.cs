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
        Hardware.Init(800, 600, 24, fullScreen);
        Image player = new Image("data\\player.bmp");

        int x = 40;
        int y = 12;
        int speed = 3;
        int finished = 0;

        // Game Loop
        while (finished == 0)
        {
            // Draw elements on screen
            Hardware.ClearScreen();
            Hardware.DrawHiddenImage(player, x, y);
            Hardware.ShowHiddenScreen();

            // Check keys and move player
            if (Hardware.KeyPressed(Hardware.KEY_RIGHT)
                    && (x < 750))
                x += speed;

            if (Hardware.KeyPressed(Hardware.KEY_LEFT)
                    && (x > 0))
                x -= speed;

            if (Hardware.KeyPressed(Hardware.KEY_UP)
                    && (y > 0))
                y -= speed;

            if (Hardware.KeyPressed(Hardware.KEY_DOWN)
                    && (y < 493))
                y += speed;

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = 1;

            // Pause till next frame (50fps)
            Hardware.Pause(20);
        }
    }
}
