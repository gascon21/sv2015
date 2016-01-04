// Program: December 27th
// Sum many numbers

/*
Create a program to ask the user how many numbers does he want to add 
and ask for that series of numbers. If a negative or zero number is 
entered, it must re-enter as many times as necessary. Finally, the sum 
all data will be displayed. Example:

Amount of data? -2
Incorrect amount
Amount of data? 3
Number 1? 2
Number 2? -5
Number 3? 10.5
Their sum is 7.5
Data are 2 -5 10.5
*/

using System;

public class December27
{
    public static void Main()
    {
        short amount;

        do
        {
            Console.Write("Amount of data: ");
            amount = Convert.ToInt16(Console.ReadLine());
            if (amount <= 0)
                Console.WriteLine("Incorrect amount");
        }
        while (amount <= 0);
        
        double[] n = new double[amount];
        double sum = 0;
        
        for (int i=0; i<amount;i++)
        {
            Console.Write("Number {0}: ", i+1);
            n[i] = Convert.ToDouble(Console.ReadLine());
            sum += n[i];
        }

        Console.WriteLine("Their sum is {0}", sum);

        Console.Write("Data are ");
        for (int i=0; i<amount;i++)
            Console.Write(n[i] + " ");
        Console.WriteLine();
    }
}


