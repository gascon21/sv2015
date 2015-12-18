using System;

public class Princess : Sprite
{
    public Princess(int nX, int nY)
    {
        x = nX;
        y = nY;
        myImage = new Image('A', 'À', ConsoleColor.Red);
    }
}
