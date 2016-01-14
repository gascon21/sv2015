using System;

// Project manager: Gonzalo García
// Programmers: Chen Chao, Jorge Montalvo, David Gascón
// Project Aquarium
// 13-01-2016


public class Aquarium
{
    public static void Run()
    {
        // TO DO
    }
    static void Main(string[] args)
    {
        // TO DO
    }
}     

// --------------------------------------

public class Background : Decoration
{
    public Background()
    {
        dSymbol = "boat";
        dX = 38;
        dY = 12;
        dWidth = 4;
        dHeight = 1;
    }
    
    public override void Draw()
    {
        Console.WriteLine(dSymbol);
    }
}

// --------------------------------------

public class Bubble : Mobile
{
    public Bubble()
    {
        x = 10;
        y = 22;
        speedY = 2;
        symbol = "*";
    }

    public override void Move()
    {
        // TO DO  
    }
}

// --------------------------------------

public class Decoration
{
    protected int dX;
    protected int dY;
    protected int dWidth;
    protected int dHeight;
    protected string dSymbol;

    public Decoration()
    {
        // TO DO
    }

    public virtual void Draw()
    {
        Console.WriteLine(dSymbol);
    }
}

// --------------------------------------

public class Fish : Mobile
{
    public override void Move()
    {
        //TO DO
    }
    
    public override void Draw()
    {
        //TO DO
    }
}

// --------------------------------------

public class Mobile
{
    protected int x;
    protected int y;
    protected int speedX;
    protected int speedY;
    protected int width;
    protected int height;
    protected string symbol;

    public Mobile()
    {
        x = 0;
        y = 0;
        speedX = 0;
        speedY = 0;
        width = 1;
        height = 1;
        symbol = "";
    }

    public Mobile(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public virtual void Move()
    {
        if (x > 0 && x < 79)
            x += speedX;
        if (y > 0 && y < 23)
            y += speedY;

        if (x < 0 || x > 79)
            speedX = -speedX;
        if (y < 0 || y > 23)
            speedY = -speedY;   
    }

    public virtual void Draw()
    {
        Console.WriteLine(symbol);
    }
}

// --------------------------------------

public class Plant : Decoration
{
    public Plant()
    {
        dSymbol = "plant";
        dX = 10;
        dY = 22;
        dWidth = 5;
        dHeight = 1;
    }
    public override void Draw()
    {
        Console.WriteLine(dSymbol);
    }
}

// --------------------------------------

public class SmoothFish : Fish
{
    public SmoothFish(int newX, int newY)
    {
        x = newX;
        y = newY;
        speedX = 3;
        speedY = 3;
        height = 3;
        width = 3;
        symbol = "-";
    }
    
    public override void Move()
    {
        x += speedX;
        y += speedY;
    }
    
    public override void Draw()
    {
        //TO DO
    }
}

// --------------------------------------

public class SpotFish : Fish
{
    public SpotFish(int newX, int newY)
    {
        x = newX;
        y = newY;
        speedX = 1;
        speedY = 1;
        height = 1;
        width = 1;
    }
    
    public override void Move()
    {
        x += speedX;
        y += speedY;
    }
    
    public override void Draw()
    {
        //TO DO
    }
}

// --------------------------------------

public class StripeFish : Fish
{
    public StripeFish(int newX, int newY)
    {
        x = newX;
        y = newY;
        speedX = 2;
        speedY = 2;
        height = 2;
        width = 2;
    }
    
    public override void Move()
    {
        x += speedX;
        y += speedY;
    }
    
    public override void Draw()
    {
        //TO DO
    }
}
