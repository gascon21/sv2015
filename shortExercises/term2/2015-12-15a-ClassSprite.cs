/* Sergio Martínez Mira
 * Class Sprite
 * */

using System;

public class Sprite
{
    int x;
    int y;
    
    public void Draw()
    {
        // TO DO
    }
    
    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
    
}


public class SpriteTest
{
    public static void Main()
    {
        Sprite sprite = new Sprite();
        sprite.MoveTo(100, 150);
    }
}
