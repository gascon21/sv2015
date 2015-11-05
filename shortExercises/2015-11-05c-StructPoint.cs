// Jose Muñoz
// Structs

using System;
public class StructPoint
{
    struct point
    {
        public short x;
        public short y;
        public byte r;
        public byte g;
        public byte b;
    }
    
    public static void Main()
    {
        point p1,p2;
        
        Console.Write("Enter x1: ");
        p1.x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter y1: ");
        p1.y = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter r1: ");
        p1.r = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter g1: ");
        p1.g = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter b1: ");
        p1.b = Convert.ToByte(Console.ReadLine());

        Console.Write("Enter x2: ");
        p2.x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter y2: ");
        p2.y = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter r2: ");
        p2.r = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter g2: ");
        p2.g = Convert.ToByte(Console.ReadLine());        
        Console.Write("Enter b2: ");
        p2.b = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("P1 = ({0}, {1}) [{2},{3},{4}]",
            p1.x, p1.y, p1.r, p1.g, p1.b);
        Console.WriteLine("P2 = ({0}, {1}) [{2},{3},{4}]",
            p2.x, p2.y, p2.r, p2.g, p2.b);
    }
}
