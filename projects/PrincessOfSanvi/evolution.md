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
