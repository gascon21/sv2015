/* Sergio Martínez Mira
 * Struct for sprites
 * */

using System;

public class ArcadeSprite
{
    struct sprites
    {
        public ushort x;
        public ushort y;
        public sbyte speedX;
        public sbyte speedY;
    }
    
    public static void Main()
    {

        sprites sprite1;
        
        Console.Write("Enter the x: ");
        sprite1.x = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Enter the y: ");
        sprite1.y = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Enter the speed of x: ");
        sprite1.speedX = Convert.ToSByte(Console.ReadLine());
        Console.Write("Enter the speed of y: ");
        sprite1.speedY = Convert.ToSByte(Console.ReadLine());
        
        Console.WriteLine("X:{0} Y:{1} SPEED X:{2} SPEED Y:{3}",
                            sprite1.x, sprite1.y, 
                            sprite1.speedX, sprite1.speedY);
    }
}
