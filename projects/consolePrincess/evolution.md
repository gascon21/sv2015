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
