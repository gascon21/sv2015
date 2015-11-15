# Console Princess - Evolution

## Version 0.01a : Just display some text on screen

```csharp
System.Console.WriteLine("A");
```

## Version 0.01b : Display text centered on screen (80 cols, 25 rows)

```csharp
System.Console.SetCursorPosition(40,12);
System.Console.WriteLine("A");
```

## Version 0.01c : Variables, using System

```csharp
using System;
...
int x = 40;
int y = 12;
Console.SetCursorPosition(x,y);
Console.WriteLine("A");
```

## Version 0.01d : Read input from the user

```csharp
int key;
key = Convert.ToInt32( Console.ReadLine() );
```

## Version 0.01e : Check if user pressed 4 (+Return) to move left

```csharp
if (key == 4)
    x = 39;
```

## Version 0.01f : Allow to move several times, pressing 4 (+Return)

```csharp
while ( 3 > 2 )  // Always
{
    Console.SetCursorPosition(x,y);
    Console.WriteLine("A");
    
    key = Convert.ToInt32( Console.ReadLine() );
    if (key == 4)
        x = x-1;
}
```

## Version 0.01g : Clear screen before "drawing each frame"

```csharp
Console.Clear();
```


## Version 0.01h : Moving in four directions

```csharp
if (key == 6)
    x = x+1;

if (key == 8)
    y = y-1;

if (key == 2)
    y = y+1;
```


## Version 0.01i : Checking screen limits

```csharp
if (key == 4)
    if (x > 0)
        x = x-1;
```


## Version 0.01j : Checking screen limits (v2)

```csharp
if ((key == 4) && (x > 0))
    x = x-1;
```


## Version 0.02a : No need to press Return

```csharp
ConsoleKeyInfo key;
...
key = Console.ReadKey();
if ((key.KeyChar == '4') && (x > 0))
    x = x-1;
```

## Version 0.02b : Two sets of keys (first approach: 2468 + WASD)

```csharp
if (((key.KeyChar == '4') || (key.KeyChar == 'a'))
        && (x > 0))
    x = x-1;
```

## Version 0.02c : Two sets of keys (second approach: cursor keys)

```csharp
if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
        && (x > 0))
    x = x-1;
```

## Version 0.02d : Esc key to finish

```csharp
int finished = 0;

while ( finished == 0 )
{
    ...
    if (key.Key == ConsoleKey.Escape)
        finished = 1;
}    
    
```


## Version 0.03a : A moving element (first approach: when a key is pressed)

```csharp
int birdX = 20;
int birdY = 5;
int birdSpeed = 1;

while ( finished == 0 )
{
    // Draw elements on screen
    Console.Clear();
    Console.SetCursorPosition(x,y);
    Console.WriteLine("A");  // Player
    Console.SetCursorPosition(birdX,birdY);
    Console.WriteLine("W");  // Bird

    ...
    // Move other elements
    if (birdX == 79)
        birdSpeed = -1;
    if (birdX == 0)
        birdSpeed = 1;
        
    birdX = birdX + birdSpeed;

}    
    
```

## Version 0.03b : A moving element (second approach: independent)

```csharp
while ( finished == 0 )
{
    // Draw elements on screen
    ...
    
    // Check keys and move player
    if (Console.KeyAvailable)
    {
        key = Console.ReadKey();
        if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
                && (x > 0))
            x = x-1;
        ...
            
        if (key.Key == ConsoleKey.Escape)
            finished = 1;
    }
        
    // Move other elements
    ...
        
    // Pause till next frame (10fps)
    Thread.Sleep(100);
}    
    
```


## Version 0.03c : Check collisions and game state - end if bird is hit

```csharp
// Check collisions and game state
if ((birdX == x) && (birdY == y))
    finished = 1;
...
// End of the game
Console.Clear();
Console.SetCursorPosition(35,12);
Console.Write("Game Over!");

Console.SetCursorPosition(1,18);
Console.ReadKey();
```


## Version 0.03d : Colors in console

```csharp
Console.ForegroundColor = ConsoleColor.Red;
Console.SetCursorPosition(x,y);
Console.WriteLine("A");  // Player

Console.ForegroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition(birdX,birdY);
Console.WriteLine("W");  // Bird
```



## Version 0.03e : Two differents "images"

```csharp
// Draw elements on screen
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.SetCursorPosition(x,y);
if (frame == 1)
    Console.WriteLine("A");  // Player
else
    Console.WriteLine("À");
...
key = Console.ReadKey();
if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
        && (x > 0))
{
    //frame = frame == 1 ? 0 : 1;
    frame = (frame + 1) % 2;
    x = x-1;
}
```


## Version 0.03f : Example of usage of "bool"

```csharp
bool finished = false;
...
while ( ! finished )
{
    ...
    // Check collisions and game state
    if ((birdX == x) && (birdY == y))
        finished = true;
}
```


## Version 0.03g : Optimized data types

```csharp
byte x = 40;
byte y = 12;
byte birdX = 20;
byte birdY = 5;
sbyte birdSpeed = 1;
ConsoleKeyInfo key;
byte frame = 1;
...
if (((key.KeyChar == '6')  || (key.Key == ConsoleKey.RightArrow))
        && (x < 79))
{
    frame = (byte) ((frame + 1) % 2);
    x++;
}
```

## Version 0.04a : Several birds, first approach: variables x 3

```csharp
byte birdX2 = 12;
byte birdY2 = 9;
sbyte birdSpeed2 = -1;

byte birdX3 = 45;
byte birdY3 = 15;
sbyte birdSpeed3 = 1;
...
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
```


## Version 0.04b : Several birds, second approach: parallel arrays

```csharp
byte[] birdX = { 20, 30, 40, 60, 15};
byte[] birdY = { 5, 7, 9, 13, 19};
sbyte[] birdSpeed = {1, -1, 1, -1, -1};
...
for(int i=0; i<5; i++)
{
    Console.SetCursorPosition(birdX[i],birdY[i]);
    Console.WriteLine("W");  // Bird
}
...
// Move other elements
for(int i=0; i<5; i++)
{
    if ((birdX[i] == 79) || (birdX[i] == 0))
        birdSpeed[i] = (sbyte) -birdSpeed[i];
}
    
for(int i=0; i<5; i++)
    birdX[i] = (byte) (birdX[i] + birdSpeed[i]);

// Check collisions and game state
for(int i=0; i<5; i++)
    if ((birdX[i] == x) && (birdY[i] == y))
        finished = true;
```


## Version 0.05a : Structs

```csharp
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
...
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
...
for(int i=0; i<5; i++)
{
    bird[i].x = (byte) (bird[i].x + bird[i].horSpeed);
    bird[i].y = (byte) (bird[i].y + bird[i].vertSpeed);
}
```
