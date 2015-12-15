// Chen Chao
// Program: Amount of negative numbers
// 28-09-2015

using System;

public class NegativeNumbers
{
    public static void Main()
    {
        int x, y;
        
        Console.WriteLine("Enter the first number.");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the second number.");
        y = Convert.ToInt32(Console.ReadLine());
        
        if (x < 0 && y < 0)
            Console.WriteLine("There are two negative numbers.");
        else if (x < 0 || y < 0)
            Console.WriteLine("There is one negative number.");
        else
            Console.WriteLine("There aren't negative numbers.");
    }
}
