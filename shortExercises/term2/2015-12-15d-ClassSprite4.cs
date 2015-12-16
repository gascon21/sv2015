// Class Sprite + setters, getters + constructors + inheritance

using System;

public class Sprite 
{
    protected int x;
    protected int y;
    
    public Sprite()
    {
        x = 512;
        y = 384;
    }
    
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

// -----------------------------------

public class Enemy : Sprite
{
    public Enemy(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
    
    public void Attack()
    {
        // TO DO
        Console.WriteLine("Attacking...");
    }
}

// -----------------------------------

public class SpriteTest 
{
    public static void Main(){

        Enemy sprite = new Enemy(50, 60);
        Console.WriteLine(sprite.GetX());
        Console.WriteLine(sprite.GetY());
        
        sprite.SetX(90);
        Console.WriteLine(sprite.GetX());
        
        sprite.MoveTo(100, 150);
        Console.WriteLine(sprite.GetX());
        Console.WriteLine(sprite.GetY());
        
        sprite.Attack();
    }
}
