// Skeleton for a shooter game, such as Who Dares Wins II
// Chen Chao
// 21-01-2016

using System;
using System.Threading;

public class Sprite
{
    protected int x;
    protected int y;
    protected string img;
    
    public Sprite(int x, int y, string img)
    {
        this.x = x;
        this.y = y;
        this.img = img;
    }
    
    public virtual void Draw()
    {
        // TO DO
    }
    
    public virtual void Move()
    {
        // TO DO
    }
    
    public virtual void Disappear()
    {
        // TO DO
    }
}

// -----------------------------------------

public class Player : Sprite
{
    protected int lives;
    protected Shot[] shots;
    protected Grenade[] grenades;
    
    public Player(int x, int y, string img) : base (x, y, "^")
    {
        lives = 3;
        grenades = new Grenade[5];
        shots = new Shot[20];
    }
    
    public void MoveUp()
    {
        y--;
    }
    
    public void MoveDown()
    {
        y++;
    }
    
    public void MoveLeft()
    {
        x--;
    }
    
    public void MoveRight()
    {
        x++;
    }
    
    public void Shoot()
    {
        // TO DO
    }
}

// -----------------------------------------

public class Grenade : Sprite
{
    public Grenade(int x, int y, string img) : base (x, y, "Q")
    {
    }
}

// -----------------------------------------

public class Shot : Sprite
{
    public Shot(int x, int y, string img) : base (x, y, ".")
    {
    }
}

// -----------------------------------------

public class Enemy : Sprite
{
    protected Shot[] shot;
    protected Grenade[] grenade;
    
    public Enemy(int x, int y, string img) : base (x, y, "X")
    {
    }
    
    public void Shoot()
    {
        // TO DO
    }
}

// -----------------------------------------

public class Rock : Sprite
{
    public Rock(int x, int y, string img) : base (x, y, "C")
    {
    }
}

// -----------------------------------------

public class Building : Sprite
{
    public Building(int x, int y, string img) : base (x, y, "M")
    {
    }
}

// -----------------------------------------

public class Level
{
    protected Screen[] screens;
    protected int currentScreen;
    
    public Level()
    {
        screens = new Screen[6];
        for (int i = 0; i < 6; i++)
            screens[i] = new Screen();
        currentScreen = 0;
    }
    
    public void AdvanceToNextScreen()
    {
        currentScreen++;
        // TODO: Animation before switching screen
    }
    
    public void Draw()
    {
        screens[currentScreen].Draw();
    }
    
    public void Move()
    {
        screens[currentScreen].Move();
    }
    
    public bool CanMoveTo(int x, int y)
    {
        return screens[currentScreen].CanMoveTo(x, y);
    }
}

// -----------------------------------------

public class Screen
{
    protected Enemy[] emeny;
    protected Rock[] rock;
    protected Building building;
    
    public void Draw()
    {
        // TO DO: draw elements of this screen
    }
    
    public void Move()
    {
        // TO DO: animate elements of this scree
    }
    
    public bool CanMoveTo(int x, int y)
    {
        // TO DO: check collisions with elements in this screen
        return true;
    }
}

// -----------------------------------------


public class LoadingScreen
{
    public void Show()
    {
        // TO DO: Show details
        
        // Finally: 10 seconds pause
        Thread.Sleep(10000);
    }
}

// -----------------------------------------

public class WelcomeScreen
{
    public void Show()
    {
        // TO DO
    }
}

// -----------------------------------------

public class Game
{
    protected int points;
    protected bool finished
    protected Player player;
    protected Level[] level;
    
    public Game()
    {
        Restart();
    }
    
    protected void Restart()
    {
        points = 0;
        finished = false;
        player = new Player(10, 10, "A");
        level = new Level[5];
        for (int i = 0; i < level.Length; i++)
            level[i] = new Level();
    }
    
    public void Run()
    {
        do
        {
            DrawElements();
            CheckKeys();
            MoveElements();
            CheckCollisions();
            PauseTillNextFrame();
        }
        while (! finished);
    }
    
    protected void DrawElements()
    {
        // TO DO
    }
    
    protected void CheckKeys()
    {
        // TO DO
    }
    
    protected void MoveElements()
    {
        // TO DO
    }
    
    protected void CheckCollisions()
    {
        // TO DO
    }
    
    protected void PauseTillNextFrame()
    {
        // TO DO
    }
}

// -----------------------------------------

public class WhoDares
{
    protected Game myGame;
    protected LoadingScreen myLoadingScreen;
    protected WelcomeScreen myWelcomeScreen;
    
    public void Run()
    {
        myLoadingScreen.Show();
        myWelcomeScreen.Show();

        ConsoleKeyInfo key = Console.ReadKey();
        
        if (key.Key == ConsoleKey.Spacebar)
            myGame.Run();
        
        // TO DO
    }
    
    public static void Main()
    {
        WhoDares myWhoDares = new WhoDares();

        myWhoDares.Run();
    }
}
