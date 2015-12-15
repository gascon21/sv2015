// Array of struct Point

using System;
public class ArrayOfStructPoint
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
        point[] p = new point[1000];
        
        for (int i=0; i<2; i++)
        {
            Console.Write("Enter x of point {0}: ", i+1);
            p[i].x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter y of point {0}: ", i+1);
            p[i].y = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter r of point {0}: ", i+1);
            p[i].r = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter g of point {0}: ", i+1);
            p[i].g = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter b of point {0}: ", i+1);
            p[i].b = Convert.ToByte(Console.ReadLine());
        }

        
        for (int i=0; i<2; i++)
            Console.WriteLine("P{0} = ({1}, {2}) [{3},{4},{5}]",
                i+1,
                p[i].x, p[i].y, 
                p[i].r, p[i].g, p[i].b);
    }
}
