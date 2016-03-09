// Mª Jesús, Pedro, Manuel y Miguel
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
        int frame = 1;
        while (true)
        {
            frame = -frame;

            Ceiling ceiling = new Ceiling();
            ceiling.SetWidth(80);
            if (frame == 1)
                ceiling.Draw('_');
            else
                ceiling.Draw('-');

            Rock rock = new Rock();
            rock.Draw();

            PauseTillNextFrame(300);
            Console.Clear();
        }
    }
}

// --------------------------------------

class Bubble
{
    public Bubble()
    {

    }
}

// --------------------------------------

class Ceiling
{
    protected int width;

    public void SetWidth(int x)
    {
        width = x;
    }


    public void Draw(char x)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(x);
            }
        }
    }
}

// --------------------------------------

public class Fish
{
    protected byte width = 25;
    protected string fishImage;
    //TODO: COLOR
    protected byte fishWidth = 25;
    protected byte fishSpeed = 2;
    protected byte fishX = 35;
    protected byte fishY = 45;

    public Fish(string newFishImage,byte fishSpeed)
    {
        fishImage = newFishImage;
    }

    public void SetFishImage(string newFishImage)
    {
        fishImage = newFishImage;
    }

    public void MoveFish()
    {
        for (int i = 0; i < 5; i++)
        {
            if ((fishX > width - fishWidth) || (fishX < 0))
                fishSpeed = -fishSpeed;
            fishX = fishX + fishSpeed);
        }
    }
}

public class RedFish : Fish
{
    
    public RedFish()
    {
        
    }
}

public class BlueFish : Fish
{
    public BlueFish()
    {
    }
}

public class YellowFish : Fish
{
    public YellowFish()
    {
    }
}


// --------------------------------------

class Grass
{
    public Grass (int GrassY)
    {
        byte[] GrassX = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        GrassY = 24;
        Console.WriteLine("1");
    }
}

// --------------------------------------

class Rock
{
    public void Draw()
    {
        Console.SetCursorPosition(22,78);
        Console.Write(" ** ");
        Console.SetCursorPosition(13, 78);
        Console.Write("****");
    }
}

// --------------------------------------
