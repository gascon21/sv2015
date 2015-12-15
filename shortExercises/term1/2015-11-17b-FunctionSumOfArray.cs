// Victor Carretero
/*
Create a C# program to calculate the sum of the elements in an array of 
integers. "Main" should be like this:

public static void Main()
{
    int[] example = {20, 10, 5, 2 };

    Console.WriteLine( "The sum of the example array is {0}", Sum(example));
}
*/
using System;

public class Challenge009
{
    public static void Main()
    {
        int[] arraynum = {20, 10, 5, 2,500,1672,643 };

        Console.WriteLine( "The sum of the example array is {0}", 
            Sum(arraynum));
    }

    public static int Sum(int[] nums )
    {
        int total = 0;
        for (int i = 0; i<nums.Length;i++)
        {
            total += nums[i];
        }
        return total;
    }
}
