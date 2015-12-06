using System;
public class Recursion1
{
    public static int Product7654(int n)
    {
        // Base case
        if (n == 0)
            return 0;
        
        // General case
        return 7654 + Product7654(n-1);
    }
    
    public static void Main()
    {
        Console.WriteLine(Product7654(0));
        
        Console.WriteLine(Product7654(7));
        
        Console.WriteLine(Product7654(1));
    }
}
