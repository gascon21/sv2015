// Chen Chao and Miguel Moya
// Program: Compound Interest
// 27-10-2015

using System;

public class CompoundInterest
{
    public static void Main()
    {
        Console.Write("Enter the amount of euros: ");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the years: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the interests: ");
        double i = Convert.ToDouble(Console.ReadLine());
        double total;
        double bases = 1;
        for (int j = 0; j < y; j++)
            bases*=(1.0f + (i/100));
            
        total = n * bases;
        Console.WriteLine("The total is {0} euros", total);
    }
}
