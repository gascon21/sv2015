// David Gascón López
// It's even or odd

using System;
public class EvenrOrOdd
{
    public static void Main()
    {
        Console.WriteLine("Enter the number");
        int x = Convert.ToInt32(Console.ReadLine());
        
        if (x % 2 == 0)
            Console.WriteLine("The number it's even");
        else
            Console.WriteLine("The number it's odd");
    }
}
