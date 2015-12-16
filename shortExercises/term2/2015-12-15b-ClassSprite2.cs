// Class Sprite + setters, getters

using System;

public class Sprite 
{
    int x;
    int y;
    
    public void Draw()
    {
        // TO DO
    }
    
    public void MoveTo(int newX , int newY)
    {
        x = newX;
        y = newY;
    }    
    
    public void SetX(int nX)
    {
        x = nX;
    }
    
    public void SetY(int nY)
    {
        y = nY;
    }   
    
    public int GetX()
    {
        return x;
    } 
    
    public int GetY()
    {
        return y;
    }     
}


public class SpriteTest 
{
    public static void Main(){

        Sprite sprite = new Sprite();
        sprite.SetX(90);
        Console.WriteLine(sprite.GetX());
        sprite.MoveTo(100, 150);
        Console.WriteLine(sprite.GetX());
        Console.WriteLine(sprite.GetY());
    }
}
