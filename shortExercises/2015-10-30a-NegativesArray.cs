// Chen Chao
// Program: Negatives Array
// 30-10-2015

using System;

public class NegativesArray
{
    public static void Main()
    {
        int negatives = 0;
        int[] data = new int[10];
        
        for (int i = 0; i<10; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Negative numbers: ");
        for (int i = 0; i<10; i++)
        {
            if (data[i] < 0)
            {
                negatives++;
                Console.Write(data[i] + " ");
            }
        }
        if (negatives == 0)
            Console.WriteLine("There are no negative numbers.");
    }
}
