// Class Sprite + setters, getters + constructors

using System;

public class Sprite 
{
    int x;
    int y;
    /*
    public Sprite()
    {
        x = 512;
        y = 384;
    }*/
    
    public Sprite(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
    
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

        Sprite sprite = new Sprite(50, 60);
        Console.WriteLine(sprite.GetX());
        Console.WriteLine(sprite.GetY());
        
        sprite.SetX(90);
        Console.WriteLine(sprite.GetX());
        
        sprite.MoveTo(100, 150);
        Console.WriteLine(sprite.GetX());
        Console.WriteLine(sprite.GetY());
    }
}
