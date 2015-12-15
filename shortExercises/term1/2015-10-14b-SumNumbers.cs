// Jorge Montalvo Blanes
// Sum numbers

using System;

public class SumNumbers
{
    public static void Main()
    {
        int number,total = 0;
        do
        {
            Console.Write("Number? ");
            number = Convert.ToInt32(Console.ReadLine());
            
            if(number != 0)
            {
                total += number;
                Console.WriteLine("Total = {0}",total);
            }
        }
        while(number!=0);
        Console.WriteLine("Finished");
    }
}
