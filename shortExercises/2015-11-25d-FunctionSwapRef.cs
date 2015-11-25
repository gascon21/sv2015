//José Miguel Leonis

// Function Swap, reference parameters

using System;
public class FunctionSwap
{
    public static void Swap (ref string word1, ref string word2)
    {
        string temp = word1;
        word1=word2;
        word2=temp;
    }
    
    public static void Main()
    {
        string w= "hello";
        string z= "world";
        
        Swap(ref w, ref z);
        Console.WriteLine(w + " " + z);
    }
}
