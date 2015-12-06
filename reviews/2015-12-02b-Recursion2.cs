using System;
public class Recursion2
{
    public static double Product(double m, double n)
    {
        if (n == 0)
            return 0;
        
        return m + Product(m, (n-1));
    }
    
    public static void Main()
    {
        double m = Convert.ToDouble(Console.ReadLine());
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Product(m,n));
    }
}
