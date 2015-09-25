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
