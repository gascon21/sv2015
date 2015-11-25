// Double 1
// Trying to double the value of a variable, approach 1: fails

using System;

public class DoublingIntegers
{
    public static void Double(int n)
    {
        n *= 2;
    }
    
    public static void Main()
    {   
        int x = 5;
        Double(x);
        Console.WriteLine(x);  // Displays 5 !!!
    }
}
