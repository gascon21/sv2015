/*
  Princess of Sanvi, a simple 2D game
*/

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        Changes
   ---------------------------------------------------
   0.08  06-Nov-2015  Level background, using tiles
   0.07  30-Oct-2015  Several birds
   0.06  23-Oct-2015  Optimized data types
   0.05  16-Oct-2015  Two images
   0.04  09-Oct-2015  Basic collision detection (overlapping rectangles)
   0.03  09-Oct-2015  A bird, moving on its own
   0.02  09-Oct-2015  Moving in four directions, not leaving the screen
   0.01  02-Oct-2015  Just display an image and move it to the left
 ---------------------------------------------------- */

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

        Image brick1 = new Image("data\\tileBrick01.bmp");
        Image brick2 = new Image("data\\tileBrick02.bmp");
        Image brick3 = new Image("data\\tileBrick03.bmp");
        Image floor = new Image("data\\tileFloor1.bmp");
        Image floorL = new Image("data\\tileFloorLeft.bmp");
        Image floorR = new Image("data\\tileFloorPit.bmp");
        Image ceiling = new Image("data\\ceiling.bmp");
        Image backB1 = new Image("data\\backBrick01.bmp");
        Image backB2 = new Image("data\\backBrick02.bmp");
        Image torch1 = new Image("data\\tileTorch1.bmp");
        Image torch2 = new Image("data\\tileTorch2a.bmp");
        Image pit1 = new Image("data\\tilePit01.bmp");
        Image pit2= new Image("data\\tilePit02.bmp");
        Image pit3 = new Image("data\\tilePit03.bmp");

        short x = 200;
        short y = 240;
        ushort playerWidth = 50;
        ushort playerHeight = 107;
        float speed = 3.8f;

        float[] birdX = { 500, 200, 150, 600, 100 };
        float[] birdY = { 120, 190, 40, 400, 470 };
        ushort birdWidth = 48;
        ushort birdHeight = 48;
        float[] birdSpeed = { -2.8f, 1.4f, 3.2f, -1.2f, 2.0f };

        byte tileWidth = 80;
        byte tileHeight = 53;
        byte levelWidth = 10;
        byte levelHeight = 10;
        // 0 = Empty, 1 = Brick1, 2 = Brick2, 3 = Brick3, 4 = Normal floor
        // 5 = Floor left, 6= right, 7 = Ceiling
        // 10=Upper back brick, 11=lower, 
        // 13 =upper torch 1, 14=2, 15=lower
        // 20=pit side 1, 21=2, 22=3
        byte[,] levelDescription =
        {
            {7,7,7,7,7,7,7,7,7,7},
            {10,0,0,0,10,0,0,0,10,0},
            {11,0,0,0,11,0,0,0,11,0},
            {0,0,0,0,0,0,0,0,0,0},
            {10,0,0,13,10,13,0,0,10,0},
            {11,0,0,15,11,15,0,0,11,0},
            {4,4,4,4,4,4,4,6,0,5},
            {1,1,1,1,1,1,1,20,0,1},
            {2,2,2,2,2,2,2,21,0,2},
            {3,3,3,3,3,3,3,22,0,3},
        };

        byte frame = 1;
        bool finished = false;

        // Game Loop
        while (! finished)
        {
            // Draw elements on screen
            Hardware.ClearScreen();

            for(int row=0; row<levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    int xPos = col * tileWidth;
                    int yPos = row * tileHeight;
                    switch(levelDescription[row,col])
                    {
                        case 1: Hardware.DrawHiddenImage(brick1, xPos, yPos); break;
                        case 2: Hardware.DrawHiddenImage(brick2, xPos, yPos); break;
                        case 3: Hardware.DrawHiddenImage(brick3, xPos, yPos); break;
                        case 4: Hardware.DrawHiddenImage(floor, xPos, yPos); break;
                        case 5: Hardware.DrawHiddenImage(floorL, xPos, yPos); break;
                        case 6: Hardware.DrawHiddenImage(floorR, xPos, yPos); break;
                        case 7: Hardware.DrawHiddenImage(ceiling, xPos, yPos); break;
                        case 10: Hardware.DrawHiddenImage(backB1, xPos, yPos); break;
                        case 11: Hardware.DrawHiddenImage(backB2, xPos, yPos); break;
                        case 13: Hardware.DrawHiddenImage(torch2, xPos, yPos); break;
                        case 15: Hardware.DrawHiddenImage(torch1, xPos, yPos); break;
                        case 20: Hardware.DrawHiddenImage(pit1, xPos, yPos); break;
                        case 21: Hardware.DrawHiddenImage(pit2, xPos, yPos); break;
                        case 22: Hardware.DrawHiddenImage(pit3, xPos, yPos); break;
                    }
                }

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
