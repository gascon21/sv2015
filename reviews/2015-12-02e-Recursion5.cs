// Max value in an array, recursive version

using System;
public class Recursion5
{
    public static int Max(int[] data, int pos)
    {
        if (pos == data.Length - 1)
            return data[pos];

        int currentNumber = data[pos];
        int currentMax = Max(data, pos+1);

        return currentNumber > currentMax ? currentNumber : currentMax; 
    }

    public static void Main()
    {
        int[] data = { 123, 324, 4234, 34, 123, 765, 1 };
        int position = 0;
        Console.WriteLine(Max(data, position));
    }
}
