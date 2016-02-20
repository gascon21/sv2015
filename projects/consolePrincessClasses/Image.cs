// 0.02 19-feb-2016 Chen Chao, Carla Liarte Felipe, Adrian Navarro García:
//                  recieving an array of string as image, remove methods GetSymbol1 and GetSymbol2
//                  and included a new method GetImage.

using System;

public class Image
{
    // Attributes
    protected string[] image;
    protected ConsoleColor color;

    public Image(string[] image, ConsoleColor c)
    {
        this.image = image; 
        color = c;
    }

    public string[] GetImage()
    {
        return image;
    }      

    public ConsoleColor GetColor()
    {
        return color;
    }
}
