using System;

public class MaxRecursive
{
    public static int Max(int[] data, int from, int to)
    {
        // Base case: size 1
        if (from == to)
            return data[from];
            
        // General case: compare data[from] with the Max of the others
        int maxOfTheOthers = Max(data, from+1, to);
        if (data[from] > maxOfTheOthers)
            return data[from];
        else
            return maxOfTheOthers;
    }
    
    public static void Main()
    {
        int[] d = { 2, 6, 7, 5 };
        Console.WriteLine( Max(d, 0, d.Length-1) );
    }
}
