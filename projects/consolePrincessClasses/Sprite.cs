// 0.02 19-feb-2016 Chen Chao, Carla Liarte Felipe, Adrian Navarro García
//                  including height, width, collissions between sprites
//                  and method Draw redefined.

using System;

public class Sprite
{
    protected int x;
    protected int y;
    protected int horSpeed;
    protected int vertSpeed;
    protected Image myImage;
    protected int frame;
    protected int width;
    protected int height;

    public Sprite()
    {
        x = 1;
        y = 1;
        myImage = new Image(new string[2],ConsoleColor.White);
    }

    public Sprite(int nX, int nY, Image img)
    {
        x = nX;
        y = nY;
        myImage = img;
    }

    public  void Draw()
    {
        Console.ForegroundColor = myImage.GetColor();
        for (int i = 0; i < myImage.GetImage().Length; i++)
        {
            Console.SetCursorPosition(x, y + 1 + i);
            Console.WriteLine(myImage.GetImage()[i]);
        }   
    }

    public virtual void Move()
    {
        // TO DO
    }

    public void ChangeFrame()
    {
        frame = (byte)((frame + 1) % 2);
    }

    public void SetX(int nX)
    {
        x = nX;
    }

    public int GetX()
    {
        return x;
    }

    public void SetY(int nY)
    {
        y = nY;
    }

    public int GetY()
    {
        return y;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetHeight()
    {
        return height;
    }

    public void MoveLeft()
    {
        x--;
        ChangeFrame();
    }

    public void MoveRight()
    {
        x++;
        ChangeFrame();
    }

    public void MoveUp()
    {
        y--;
        ChangeFrame();
    }

    public void MoveDown()
    {
        y++;
        ChangeFrame();
    }

    public bool CollisionsWith(Sprite otherSprite)
    {
        return (CollisionsWith(otherSprite.GetX(),
                otherSprite.GetY(),
                otherSprite.GetX() + otherSprite.GetWidth(),
                otherSprite.GetY() + otherSprite.GetHeight()));
    }

    public bool CollisionsWith(int xStart, int yStart, int xEnd, int yEnd)
    {
        if ((x < xEnd) &&
            (x + width > xStart) &&
            (y < yEnd) &&
            (y + height > yStart)
            )
            return true;
        return false;
    }
}
