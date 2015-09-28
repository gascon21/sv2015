// David Gascón López
// It's even or odd

using System;
public class EvenrOrOdd
{
    public static void Main()
    {
        int x, remainder; 
        
        Console.WriteLine("Enter the number");
        x = Convert.ToInt32(Console.ReadLine());
        remainder = x % 2;
        
        if (remainder == 0)
            Console.WriteLine("The number it's even");
        else
            Console.WriteLine("The number it's odd");
    }
}
