using System;

public class Point3D
{
    protected double x;
    protected double y;
    protected double z;

    public Point3D(double x, double y, double z)
    {
        MoveTo(x, y, z);
    }

    public void MoveTo(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double GetX()
    {
        return x;
    }
    public double GetY()
    {
        return y;
    }
    public double GetZ()
    {
        return z;
    }

    public void SetX(double x)
    {
        this.x = x;
    }

    // ...

    public double DistanceTo( Point3D q )
    {
        return Math.Sqrt(
            (x - q.GetX()) * (x - q.GetX()) +
            (y - q.GetY()) * (y - q.GetY()) +
            (z - q.GetZ()) * (z - q.GetZ()));
    }

    public override string ToString()
    {
        return "("+x+","+y+","+z+")";
    }


}

public class Point3DTest
{
    public static void Main()
    {
        Point3D p1 = new Point3D(12, 3.5, -7);
        Point3D p2 = new Point3D(-15, 3.4, 17);

        Console.WriteLine("Points {0} and {1}:",
            p1.ToString(), p2.ToString() );

        Console.WriteLine("Distance: {0}",
            p1.DistanceTo(p2));

        Console.WriteLine("p1.x : {0}",
            p1.GetX());

        p2.SetX(-34.567);
        Console.WriteLine("p2.x now is : {0}",
            p2.GetX());

        p2.MoveTo(0, 0, 0);
        Console.WriteLine("P2 is now:" + 
            p2.ToString());

        // ...
    }
}
