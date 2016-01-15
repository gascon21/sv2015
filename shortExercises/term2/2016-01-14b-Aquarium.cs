// Aquarium in Console Mode, as an example of classes handling

using System;
using System.Threading;

// --------------------------------------

public class Aquarium
{
    protected Bubble myBubble;
    protected Rock myRock;
    protected int amountOfFishes;
    protected Fish[] fishes;

    public Aquarium()
    {
        myBubble = new Bubble(10, 24);
        myRock = new Rock(20);
        amountOfFishes = 6;
        fishes = new Fish[amountOfFishes];
        fishes[0] = new YellowFish(20, 12);
        fishes[1] = new YellowFish(40, 15);
        fishes[2] = new YellowFish(55, 21);
        fishes[3] = new BlueFish(25, 13);
        fishes[4] = new BlueFish(70, 19);
        fishes[5] = new BlueFish(30, 14);
    }

    public void Run()
    {
        bool finished = false;
        ConsoleKeyInfo key;

        while (!finished)
        {
            // Draw elements
            Console.Clear();
            myRock.Draw();
            for (int i = 0; i < amountOfFishes; i++)
                fishes[i].Draw();
            myBubble.Draw();

            // Move elements for next frame
            for (int i = 0; i < amountOfFishes; i++)
                fishes[i].Move();
            myBubble.Move();

            // And wait for the next frame
            Thread.Sleep(100);

            // Also, we can let the user exit the program, pressing ESC
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                    finished = true;
            }
        }

        Console.Clear();
        Console.SetCursorPosition(35, 12);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Bye Bye!");
        Console.ReadKey();
    }


    public static void Main()
    {
        Aquarium myAquarium = new Aquarium();
        myAquarium.Run();
    }
        
}

// --------------------------------------

public class Sprite
{
    protected int x;
    protected int y;
    protected int xSpeed;
    protected int ySpeed;
    protected string image;
    protected ConsoleColor color;

    public Sprite(int x, int y, string image, ConsoleColor color)
    {
        this.x = x;
        this.y = y;
        this.image = image;
        this.color = color;
    }

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(image);
    }

    public virtual void Move()
    {
        x += xSpeed;
        y += ySpeed;
    }
}

// --------------------------------------

public class Bubble : Sprite
{
    public Bubble(int x, int y) : base (x, y, "o", ConsoleColor.Cyan)
    {
        xSpeed = 0;
        ySpeed = -1;
    }

    // Movement for a bubble: upwards
    public override void Move()
    {
        base.Move();
        if (y < 2)
            y = 24;
    }
}

// --------------------------------------

public class Rock : Sprite
{
    public Rock(int x) : base(x, 24, "/\\M /\\", ConsoleColor.DarkRed)
    {
        xSpeed = 0;
        ySpeed = 0;
    }

    public override void Move()
    {
        // Do nothing: rocks remain static
    }
}

// --------------------------------------

public class Fish : Sprite
{
    public Fish(int x, int y, string image, ConsoleColor color) 
        : base(x, y, image, color)
    {
        xSpeed = 1;
        ySpeed = 0;
    }

    // Movement for a bubble: sidewards
    public override void Move()
    {
        base.Move();
        if ((x < image.Length + 1) || (x > 77 - image.Length))
            xSpeed = - xSpeed;
    }
}

// --------------------------------------

public class YellowFish : Fish
{
    public YellowFish(int x, int y)
        : base(x, y, "<=-><", ConsoleColor.Yellow)
    {
    }
}

// --------------------------------------

class BlueFish : Fish
{
    public BlueFish(int x, int y)
        : base(x, y, "(====)<", ConsoleColor.Blue)
    {
        xSpeed = -1;
    }
}
