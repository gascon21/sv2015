/*
    Sacha Van de sijpe
    Statistics
*/

using System;

public class Statistics
{
    public static void Main()
    {
        Console.Write("Number? ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = number;
        int ammount = 1;
        int average = number;
        int max = number, min = number;
        
        while(number != -1)
        {
            Console.WriteLine
                ("Total={0} Amount={1} Average={2} Maximum={3} Minimum={4}",
                    sum,ammount,average,max,min);
            
            ammount ++;
            
            Console.Write("Number? ");
            number = Convert.ToInt32(Console.ReadLine());
            
            sum += number;
            average = sum / ammount;
            
            if (number > max)
                max = number;
            if (number < min)
                min = number;
        }
        Console.WriteLine("Bye!");
    }
}
