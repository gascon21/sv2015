using System;

public class Recursion1
{
    public static void Main()
    {
        Console.WriteLine( Power(5, 2) );
    }

    public static int Power (int b, uint e)
    {
        if (e == 0)
            return 1;

        return b * Power(b, e - 1);
    }

}
