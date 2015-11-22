# PrincessOfSanvi - Evolution

## Version 0.01 : Just display an image and move it to the left

```csharp
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
            if (Hardware.KeyPressed(Hardware.KEY_RIGHT))
                x += speed;

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = 1;

            // Pause till next frame (10fps)
            Hardware.Pause(20);
        }
    }
}
```

## Version 0.02 : Moving in four directions, not leaving the screen

```csharp
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
```


## Version 0.03 : A bird, moving on its own

```csharp
Image bird = new Image("data\\bird.bmp");
int birdX = 500;
int birdY = 50;
int birdSpeed = -2;
...
Hardware.DrawHiddenImage(bird, birdX, birdY);
...
// Move other elements
if ((birdX > 750) || (birdX < 5))
    birdSpeed = -birdSpeed;

birdX = birdX + birdSpeed;
```


## Version 0.04 : Basic collision detection (overlapping rectangles)

```csharp
int x = 400;
int y = 250;
int playerWidth = 50;
int playerHeight = 107;
int birdX = 500;
int birdY = 150;
int birdWidth = 48;
int birdHeight = 48;
...
// Check collisions and game state
if ((birdX > x-birdWidth)
        && (birdX < x+playerWidth)
        && (birdY > y-birdHeight)
        && (birdY < y+playerHeight))
    finished = 1;
```


## Version 0.05 : Two images

```csharp
Image player = new Image("data\\player.bmp");
Image player2 = new Image("data\\player2.bmp");
...
// Draw elements on screen
Hardware.ClearScreen();
if (frame < 5)
    Hardware.DrawHiddenImage(player, x, y);
else
    Hardware.DrawHiddenImage(player2, x, y);
...
// Check keys and move player
if (Hardware.KeyPressed(Hardware.KEY_RIGHT)
        && (x < screenWidth-playerWidth))
{
    frame = (frame + 1) % 10;
    x += speed;
}
```


## Version 0.06 : Optimized data types

```csharp
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
...
    if (Hardware.KeyPressed(Hardware.KEY_ESC))
        finished = true;
    ...

    birdX = (short)(birdX + birdSpeed);
    ...
}
```


## Version 0.07 : Several birds

```csharp
float[] birdX = { 500, 200, 150, 600, 100 };
float[] birdY = { 150, 200, 300, 400, 520 };
float[] birdSpeed = { -2.8f, 1.4f, 3.2f, -1.2f, 2.0f };

// Game Loop
while (! finished)
{
...
    for (int i = 0; i < 5; i++)
        Hardware.DrawHiddenImage(bird, 
            (short) birdX[i], (short) birdY[i]);
    ...
}
```


## Version 0.08 : Level background, using tiles

```csharp
Image brick1 = new Image("data\\tileBrick01.bmp");
Image brick2 = new Image("data\\tileBrick02.bmp");
...
Image pit2= new Image("data\\tilePit02.bmp");
Image pit3 = new Image("data\\tilePit03.bmp");
...
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
...
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
            ...
            case 22: Hardware.DrawHiddenImage(pit3, xPos, yPos); break;
        }
    }
```



## Version 0.09 : Support for PNG images and TTF fonts

```csharp
Image intro = new Image("data\\intro.png");
Font font18;
...
font18 = new Font("data/Joystix.ttf", 18);
// Intro
Hardware.ClearScreen();
Hardware.DrawHiddenImage(intro, 0, 0);
Hardware.WriteHiddenText("Princess of Sanvi",
        290, 90,
        0xF0, 0xF0, 0xF0,
        font18);
Hardware.WriteHiddenText( "Press S to Start",
        310, 500,
        0xF0, 0xF0, 0xF0,
        font18);
Hardware.ShowHiddenScreen();
do  // Wait for user to press S (Start)
{
    Hardware.Pause(50);
} while (!Hardware.KeyPressed(Hardware.KEY_S));

```


## Version 0.10 : End screen

```csharp
...
    // Pause till next frame (50fps)
    Hardware.Pause(20);
}
Hardware.ClearScreen();
Hardware.DrawHiddenImage(endScreen,0,0);
Hardware.WriteHiddenText("Game over",
    350, 300,
    0xF0, 0xF0, 0xF0,
    font18);
Hardware.ShowHiddenScreen();
Hardware.Pause(5000);
```
