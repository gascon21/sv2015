using System;
using System.Threading;

public class Game
{
    // Attributes
    protected Princess myPrincess;
    protected Level  myLevel;

    // Pending
    const byte SIZE = 5;
    Sprite player;
    Enemy[] bird = new Enemy[SIZE];
    static bool finished = false;

    // Operations
    public Game()
    {
        
        player = new Princess(40, 12);

        bird[0] = new Enemy(20, 5, 1, 1, ConsoleColor.Yellow);
        bird[1] = new Enemy(30, 7, -1, 0, ConsoleColor.Green);
        bird[2] = new Enemy(40, 9, 1, -1, ConsoleColor.Blue);
        bird[3] = new Enemy(60, 13, -1, 0, ConsoleColor.Yellow);
        bird[4] = new Enemy(15, 19, -1, 0, ConsoleColor.White);
    }

    public  void DrawElements()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        player.Draw();
        
        for (int i = 0; i < 5; i++)
            bird[i].Draw();
    }

    public  void CheckKeys()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (((key.KeyChar == '4') || (key.Key == ConsoleKey.LeftArrow))
                    && (player.GetX() > 0))
            {                
                player.MoveLeft();
            }

            if (((key.KeyChar == '6') || (key.Key == ConsoleKey.RightArrow))
                    && (player.GetX() < 79))
            {
                player.MoveRight();
            }

            if (((key.KeyChar == '8') || (key.Key == ConsoleKey.UpArrow))
                    && (player.GetY() > 0))
            {
                player.MoveUp();
            }

            if (((key.KeyChar == '2') || (key.Key == ConsoleKey.DownArrow))
                    && (player.GetY() < 24))
            {
                player.MoveDown();
            }

            if (key.Key == ConsoleKey.Escape)
                finished = true;
        }
    }

    public  void MoveElements()
    {
        for (int i = 0; i < 5; i++)
            bird[i].Move();
    }

    public  void CheckCollisions()
    {
        for (int i = 0; i < 5; i++)
            if ((bird[i].GetX() == player.GetX()) 
                    && (bird[i].GetY() == player.GetY()))
                finished = true;
    }

    public  void PauseTillNextFrame()
    {
        Thread.Sleep(100);
    }

    public void Run()
    {
        while (!finished)
        {
            DrawElements();
            CheckKeys();
            MoveElements();
            CheckCollisions();
            PauseTillNextFrame();
        }
    }
} 
