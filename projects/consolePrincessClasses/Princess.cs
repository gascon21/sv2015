// 0.02 19-feb-2016 Chen Chao, Carla Liarte Felipe, Adrian Navarro García
//    including own image

using System;

public class Princess : Sprite
{
    private string[] image = {
    " [¨]",
    "-----",
    "  |",
    " | |"
    };

    public Princess(int nX, int nY)
    {
        x = nX;
        y = nY;
        height = 4;
        width = 5;
        myImage = new Image(image, ConsoleColor.Red);
    }
}
