// Double 2
// Trying to double the value of a variable, approach 2: "return"
//   (Problem: the logic changes)

using System;

public class DoublingIntegers
{
    public static int Double(int n)
    {
        return n*2;
    }
    
    public static void Main()
    {   
        int x = 5;
        x = Double(x);
        Console.WriteLine(x);
    }
}
