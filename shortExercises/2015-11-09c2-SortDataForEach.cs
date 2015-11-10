// Chen Chao
// Program: Sort data
// 08-11-2015

using System;

public class SortData
{
    public static void Main()
    {
        const byte SIZE = 10;
        short[] number = new short [SIZE];
        short exchange;
        
        for (byte i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the number {0}: ", i+1);
            number[i] = Convert.ToInt16(Console.ReadLine());
        }

        Console.Write("Unsorted data: ");
        foreach (int n in number)
            Console.Write(" {0}", n);
        Console.WriteLine();
        
        for (int i = 0; i < SIZE-1; i++)
        {
            for (int j = i+1; j < SIZE; j++)
            {
                if (number[i] > number[j])
                {
                    exchange = number[i];
                    number[i] = number[j];
                    number[j] = exchange;
                }
            }
        }
        
        Console.Write("Sorted data: ");
        foreach (int n in number)
            Console.Write(" {0}", n);
        Console.WriteLine();
    }
}
