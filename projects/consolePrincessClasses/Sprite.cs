using System;

public class Sprite
{
    protected int x;
    protected int y;
    protected int horSpeed;
    protected int vertSpeed;
    protected Image  myImage;
    protected int frame;

    public Sprite()
    {
        x = 1;
        y = 1;
        myImage = new Image('o','o',ConsoleColor.White);
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
        Console.SetCursorPosition(x, y);
        if (frame == 1)
            Console.WriteLine(myImage.GetSymbol1());  // Player
        else
            Console.WriteLine(myImage.GetSymbol2());
    }

    public  void Move()
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
}
