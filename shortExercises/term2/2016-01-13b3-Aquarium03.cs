// Vicente, Jose Vicente, Sergio y Victor.

using System;

public class Aquarium
{
    public Aquarium () //Constructor
    {

    }
    public virtual void Draw()
    {

    }
    public virtual void Move()
    {

    }

    public virtual void Time()
    {

    }

    static void Main()
    {
        const int SIZE = 10;
        Fish[] MyFish = new Fish[SIZE];
        /* for (int i = 0; i < SIZE; i++)
        /      MyFish[i].Draw();
       */
    }
}

// --------------------------------------

public class BigFish : Fish
{
    public BigFish()
    {

    }

    public override void Move()
    {

    }
}

// --------------------------------------

public class Bubble : Aquarium
{
    protected int time;
    protected short x, y;
    protected char img;

    public Bubble()
    {
        time = 5000;
        x = 20;
        y = 24;
        img = 'o';
    }

    public override void Draw()
    {
      /*  for (int i = 0; i < 3; i++)
        {
            //Console.ForegroundColor = bird[i].image.color;
            Console.SetCursorPosition(bubbles[i].x, bubbles[i].y); //Posicion
            if (i == 2)
                img = 'O';
            Console.WriteLine(bubbles[i].img); //Poner burbuja
        }*/
    }

    public override void Move()
    {
        y = y--;
    }

    public short getX()
    {
        return x;
    }

    public short getY()
    {
        return y;
    }

    public char getImg()
    {
        return img;
    }

    public void setX(short posX)
    {
        x = posX;
    }

    public void setY(short posY)
    {
        y = posY;
    }

    public void setImg(char charImg)
    {
        img = charImg;
    }
}

// --------------------------------------

public class Fish
{
    protected string characters;
    protected byte x;
    protected byte y;

    public virtual void Move()
    {

    }
    public virtual void Draw()
    {

    }
    public void SetX(byte nX)
    {
        x = nX;
    }

    public byte GetX()
    {
        return x;
    }

    public void SetY(byte nY)
    {
        y = nY;
    }

    public byte GetY()
    {
        return y;
    }

}

// --------------------------------------

public class Flora : Aquarium
{
    protected short x, y;
    protected char img;

    public Flora(short posX, short posY)
    {
        x = posX;
        y = posY;
        img = '|';
    }

    public override void Draw()
    {
        /*  for (int i = 0; i < 3; i++)
        /   {
        /       
        /       Console.SetCursorPosition(floras[i].x, floras[i].y); //Posicion
        /       Console.WriteLine(floras[i].img); //Poner burbuja
        /}
       */
    }

    public override void Move()
    {
        y = y--;
    }

    public short GetX()
    {
        return x;
    }

    public short GetY()
    {
        return y;
    }

    public char GetImg()
    {
        return img;
    }

    public void SetX(short posX)
    {
        x = posX;
    }

    public void SetY(short posY)
    {
        y = posY;
    }

    public void SetImg(char charImg)
    {
        img = charImg;
    }
}

// --------------------------------------

public class LittleFish : Fish
{
    public LittleFish()
    {

    }

    public override void Move()
    {

    }
}

// --------------------------------------

public class MiddleFish : Fish
{
    public MiddleFish()
    {

    }

    public override void Move()
    {

    }
}
