// Pedro Antonio Pérez
// Maria Jesus Atalaya
// Manuel Coronado
// Miguel Moya

using System;
using System.Threading;

class Aquarium
{
    public static void PauseTillNextFrame(int x)
    {
        Thread.Sleep(x);
    }

    static void Main()
    {

        Ground ground = new Ground();
        
        BlueFish bluefish = new BlueFish(35, 20);
        RedFish redfish = new RedFish(45, 38);
        YellowFish yellowfish = new YellowFish(30, 22);
        while (true)
        {
            bluefish.DrawFish();
            redfish.DrawFish();
            yellowfish.DrawFish();
            bluefish.MoveFish();
            redfish.MoveFish();
            yellowfish.MoveFish();
            Thread.Sleep(40);
        }

        while (true)
        {
            Console.Clear();

            Ceiling ceiling = new Ceiling();
            ceiling.Draw();

            Rock rock = new Rock();
            rock.Draw(50, 22);
            
            PauseTillNextFrame(1000);
        }
    }
}

// --------------------------------------

// Manuel Coronado Cuevas
// 13/01/2016

class Grass
{
    public Grass ()
    {
        int BubbleY= 24;
        
        int[] BubbleX = {9,4,5,8,24,32,55,78};
            
        for(int j=0; BubbleY > j; BubbleY--)
            for(int i=0; i<BubbleX.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(BubbleX[i],BubbleY);
                Console.WriteLine("0");  // Bubble
                // To Do: Set Fps
                Console.Clear();
            }
    }
}

// --------------------------------------

class Ceiling
{
    protected int width;

    public Ceiling()
    {
        width = 80;
    }


    public void Draw()
    {
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < width; j++)
                Console.Write('-');
    }
}

// --------------------------------------

public class Fish
{
    //TODO: COLOR
    protected string fishImage;
    protected byte fishSpeed = 1;
    protected byte fishX = 35;
    protected byte fishY = 45;

    public Fish(byte newFishX,byte newFishY) //Base constructor
    {
        fishX = newFishX;
        fishY = newFishY;
    }

    public virtual void DrawFish()
    {
            Console.Clear();
            Console.SetCursorPosition(fishX, fishY);
            Console.Write("F");
    }
    public virtual void  MoveFish()
    {
            fishSpeed++;
            if((fishX == 0) ||(fishX ==79))
            {
                fishSpeed--;
            }
        }
    }

public class RedFish : Fish
{
    public RedFish() :base(16,38) //Dependent of base constructor but with own values
    {
        
    }

    public RedFish(byte newFishX, byte newFishY) : base(newFishX, newFishY) //Dependent of base constructor but with own values
    {
    }
    public override void MoveFish() //Move method for redfish
    {
        fishSpeed++;
        if ((fishX == 0) || (fishX == 79))
        {
            fishSpeed--;
        }
    }

    public override void DrawFish()
    {
        Console.Clear();
        Console.SetCursorPosition(fishX, fishY);
        Console.Write("R");
    }
}

public class BlueFish : Fish
{
    public BlueFish() :base(47,21) //Dependent of base constructor but with own values
    {
    }

    public BlueFish(byte newFishX, byte newFishY) : base(newFishX, newFishY) //Dependent of base constructor but with own values
    {
    }

    public override void MoveFish()
    {
        fishSpeed++;
        if ((fishX == 0) || (fishX == 79))
        {
            fishSpeed--;
        }
    }

    public override void DrawFish() //Move method for bluefish
    {
        Console.Clear();
        Console.SetCursorPosition(fishX, fishY);
        Console.Write("B");
    }
}

public class YellowFish : Fish
{
    public YellowFish() :base(23,63) //Dependent of base constructor but with own values
    {
    }

    public YellowFish(byte newFishX, byte newFishY) : base(newFishX, newFishY) //Dependent of base constructor but with own values
    {
    }

    public override void DrawFish() //Draw method for yellowfish
    {
        Console.Clear();
        Console.SetCursorPosition(fishX, fishY);
        Console.Write("Y");
    }

    public override void MoveFish() //Move method for Yellowfish
    {
        fishSpeed++;
        if ((fishX == 0) || (fishX == 79))
        {
            fishSpeed--;
        }
    }
}

// --------------------------------------

// Manuel Coronado Cuevas
// 13/01/2016

public class Ground
{
    public Ground()
    {
        int GrassY= 24;
        
        // It needs to be shorter
        int[] GrassX = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
            15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
            30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44,
            45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
            60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73,
            74, 75, 76, 77, 78, 79};
        
        for(int i=0; i<GrassX.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(GrassX[i],GrassY);
            Console.WriteLine("1");  // Grass
        }
        
        // TO DO: Add Movement
    }
}

// --------------------------------------

class Rock
{
    public void Draw(int x, int y)
    {
        Console.SetCursorPosition(x,y);
        Console.Write("***");
        Console.SetCursorPosition(x, y +1);
        Console.Write("***");
        Console.SetCursorPosition(x, y +2);
        Console.Write("***");
    }
}
