// 0.02 19-feb-2016 Chen Chao, Carla Liarte Felipe, Adrian Navarro García
//                  including own image and redefined method Move.

using System;

public class Enemy : Sprite
{
    private string[] image = {
    "<0\"",
    " ---",
    "   !!"
    };

    public Enemy(int nX, int nY, int xSpeed, int ySpeed, ConsoleColor color)
    {
        x = nX;
        y = nY;
        horSpeed = xSpeed;
        vertSpeed = ySpeed;
        height = 3;
        width = 5;
        myImage = new Image(image, color);
    }


    public override void Move()
    {
        if ((x + width >= 78) || (x <= 1))
            horSpeed = (sbyte)-horSpeed;

        if ((y + height >= 22) || (y <= 1))
            vertSpeed = (sbyte)-vertSpeed;

        x = (byte)(x + horSpeed);
        y = (byte)(y + vertSpeed);
    }
}
