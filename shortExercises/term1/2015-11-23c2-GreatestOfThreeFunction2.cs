// Miguel Moya Ortega

using System;

public class theBiggest
{
    public static double GreatestOfThree(double x, double y, double z)
    {
        double biggest;

        if (x > y)
            biggest = x;
        else
            biggest = y;

        if (biggest < z)
            biggest = z;

        return biggest;
    }
    
    public static void Main()
    {
        Console.WriteLine( GreatestOfThree(2.5, 10, 8) );
        Console.WriteLine( GreatestOfThree(5, 5, 3) );
    }
}
