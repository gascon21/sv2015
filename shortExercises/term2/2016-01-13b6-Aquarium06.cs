// Program aquarium
// Made by Indra Lopez, Adrian Navarro and Jose Muñoz
// Jefe maximo de proyecto: Indra Lopez


using System;
/*
Clases:
* 
Fish
Clownfish
Bluefish
SeaHorse
Algae
Bubbles
Aquarium
Long
Short
Background
 * */

public class  Aquarium
{
    public static void Main()
    {
        Fish [] fishes = new Fish[8];
        fishes[0] = new Fish();
        fishes[1] = new Clownfish(4, 5, 20, 30);
        fishes[2] = new Bluefish(6, 8, 10, 15);
        fishes[3] = new Clownfish(3, 8, 40, 60);
        fishes[4] = new SeaHorse(3, 6, 20, 50);
        fishes[5] = new Bluefish(2, 9, 20, 70);
        fishes[6] = new SeaHorse(4, 8, 30, 20);
        fishes[7] = new Clownfish(3, 9, 10, 10);
        
        Bubbles burbuji = new Bubbles(20);

    }
}

// ------------------------------------

// Class Bubbles 
public class Bubbles
{
    protected string image = "00";
    protected int positionX;
    protected int positionY;
    
    public Bubbles (int pos) {
        positionX = pos;
        positionY = 0;
    }
    
    public void DoSpeed() {
        while (positionY < 100){
            positionY++;
        }
    }
}
//End Class Bubbles

// Class Algae
public class Algae
{
    protected string image;
    protected int positionX ;
    
    public Algae ()
    {
        image = "I";
    }
    public void PositionX(int newPositionX)
    {
        positionX = newPositionX;
    }
}

public class ShortAlgae : Algae
{
    public ShortAlgae ()
    {
        image = "i";
    }
}

public class Long : Algae
{
    public Long ()
    {
        image = "I";
    }
    public void Move()
    {
        positionX++;
        positionX--;
    }
}

//End Class Alga

// Class Fish 
public class Fish
{
    protected int speedX = 0,speedY = 0,positionX=0,positionY=0;
    protected string image="#";
    
    public Fish ()
    {
        speedX = 0;
        speedY = 0;
        positionX=0;
        positionY=0;
        image="#";
    }
}

public class Clownfish : Fish
{
    protected string imageClownfish="C#3";
            
    public Clownfish (int speedX,int speedY,int positionX,int positionY)
    {
        image=imageClownfish;
    }
}

public class Bluefish : Fish
{
    protected string imageBluefish="C###3";
            
    public Bluefish (int speedX,int speedY,int positionX,int positionY)
    {
        image=imageBluefish;
    }
}

public class SeaHorse : Fish
{
    protected string imageSeaHorse="3";
            
    public SeaHorse (int speedX,int speedY,int positionX,int positionY)
    {
        image=imageSeaHorse;
    }
}


// End Class Fish 
