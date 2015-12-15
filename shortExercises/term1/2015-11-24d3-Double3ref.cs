// Double 3
// Trying to double the value of a variable, approach 3: "ref"
//     Reference parameters: usually to return more that one value

using System;

public class DoublingIntegers
{
    public static void Double(ref int n)
    {
        n *= 2;
    }
    
    public static void Main()
    {   
        int x = 5;
        Double(ref x);
        Console.WriteLine(x);
    }
}
