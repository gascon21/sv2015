/** Ruben Blanco, Cristian Navarrete & Jose Manuel Mas
    Team Coordinator: Ruben Blanco
    Program: Aquarium
**/

using System;
using System.Threading;

//----------------------------------------------------

public class Aquarium
{
    public  static void Main()
    {
        ConsoleKeyInfo key;
        bool finished = false;
        Fishes myFish = new Fishes();
        Environment myEnv = new Environment();
        Coral myCoral = new Coral();
        SeaWeed myWeed = new SeaWeed();
        Rocks myRock = new Rocks();
        Bubbles myBubble = new Bubbles();
        
        while (!finished )
        {
            Console.Clear();
            
            myFish.Draw();
            myFish.Move();
            
            myEnv.Draw();
            myCoral.Draw();
            myWeed.Draw();
            myRock.Draw();
            myBubble.Draw();
            
            Thread.Sleep(100);
            
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                finished = true;
            }
        }
            
        Console.Clear();
        Console.SetCursorPosition(35,12);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Bye Bye!");
        Console.ReadKey();
    }
}

//----------------------------------------------------

public class Fishes // TO DO: TYPES OF FISHES
{
    protected ConsoleColor color;
    protected int fishX; 
    protected int fishY;
    protected int xSpeed;
    protected int ySpeed;
    protected char symbol;
    
    public Fishes()
    {
        fishX = 20;
        fishY = 12;
        xSpeed = 1;
        symbol = 'W';
        color = ConsoleColor.Green;
    }
    
    public void Draw()
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(fishX, fishY);
        Console.WriteLine(symbol);
    }
    
    public int Move()
    {
        if (fishX == 79)
                xSpeed = -1;
            if (fishX == 0)
                xSpeed = 1;
                
        fishX += xSpeed;
        return fishX;
    }
}

// -----------------------------------------------

public class Environment 
{
    // TO DO : ENVIRONMENT SPRITES,TYPES OF PLANTS
    protected int x;
    protected int y;
    protected char  symbol;
    protected ConsoleColor color;
    

    public Environment()//Constructor
    {
        x = 20;
        y = 20;
        symbol = 'x';
        color = ConsoleColor.Red;
    }

    public Environment(int nX, int nY, char img)//Constructor2
    {
        x = nX;
        y = nY;
        symbol = img;
    }

    public virtual void  Draw()
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);
        Console.WriteLine(symbol);
    }
}
//----------------------------------------------------------


public class Coral:Environment
{
    protected char  CoralForm;
    
    public Coral()//Constructor
    {
        x = 50;
        y = 19;
        CoralForm = 'Y';
        color= ConsoleColor.Magenta;
    }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(CoralForm);
        }
}

public class SeaWeed:Environment
{
    protected char  SeaWeedForm;
    
    public SeaWeed()
    {
        x = 50;
        y = 20;
        SeaWeedForm = '&';
        color= ConsoleColor.Green;
    }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(SeaWeedForm);
        }
}

public class Rocks:Environment
{
    protected char  RocksForm;
    
    public Rocks()
    {
        x = 21;
        y = 20;
        RocksForm = '#';
        color= ConsoleColor.Gray;
    }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(RocksForm);
        }
}

// --------------------------------------

public class Bubbles:Environment
{
    protected char  BubblesForm;
    
    public Bubbles()
    {
        x = 20;
        y = 18;
        BubblesForm = 'O';
        color= ConsoleColor.Blue;
    }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(BubblesForm);
        }
}


