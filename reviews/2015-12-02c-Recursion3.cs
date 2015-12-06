using System;
public class Recursion3
{
    public static int Power(int m, int n)
    {
        if (n == 0)
            return 1;
        
        return m * Power (m , n-1);
    }
    
    public static void Main()
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Power(m,n));
    }
}
