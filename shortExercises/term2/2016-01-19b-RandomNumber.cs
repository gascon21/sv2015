using System;

public class Random
{
    protected static float m = 233280.0f;
    protected static float a = 9301;
    protected static float c = 49297;
    protected static float seed = 1;

    public static float GetFloat()
    {
        seed = (seed * a + c) % m;
        return Math.Abs(seed / m);
    }

    public static int GetInt(int max)
    {
        return (int) (GetFloat() * max);
    }

    public static int GetInt(int min, int max)
    {
        return GetInt(max-min) + min;
    }
}

public class RandomTest
{
    public static void Main()
    {
        Console.WriteLine("Random float:");
        Console.WriteLine( Random.GetFloat() );
        Console.WriteLine( Random.GetFloat() );

        Console.WriteLine("Random int, 0 to 200:");
        Console.WriteLine(Random.GetInt(200));
        Console.WriteLine(Random.GetInt(200));
        Console.WriteLine(Random.GetInt(200));

        Console.WriteLine("Random int, 100 to 160:");
        Console.WriteLine(Random.GetInt(100, 160));
        Console.WriteLine(Random.GetInt(100, 160));
        Console.WriteLine(Random.GetInt(100, 160));
    }
}
