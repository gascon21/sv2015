using System;

public class Enemy : Sprite
{

    public Enemy(int nX, int nY, int xSpeed, int ySpeed, ConsoleColor color)
    {
        x = nX;
        y = nY;
        horSpeed = xSpeed;
        vertSpeed = ySpeed;
        myImage = new Image('W', 'w', color);
    }


    public void Move()
    {
        if ((x >= 78) || (x <= 1))
            horSpeed = (sbyte)-horSpeed;

        if ((y >= 22) || (y <= 1))
            vertSpeed = (sbyte)-vertSpeed;

        x = (byte)(x + horSpeed);
        y = (byte)(y + vertSpeed);
    }
}
