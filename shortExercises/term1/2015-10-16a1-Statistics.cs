/*
    Sacha Van de sijpe
    Statistics
*/

using System;

public class Statistics
{
    public static void Main()
    {
        int number;
        int sum = 0;
        int ammount = 1;
        int average = 0;
        int max = 0, min = 0;
        
        do
        {
            Console.Write("Number? ");
            number = Convert.ToInt32(Console.ReadLine());
            
            sum += number;
            average = sum / ammount;
            
            if (ammount == 1)
                max = number;
            else if (number > max)
                max = number;
                
            if (ammount == 1)
                min = number;
            else if (number < min)
                min = number;
            
            if (number != -1)
            Console.WriteLine
                ("Total={0} Amount={1} Average={2} Maximum={3} Minimum={4}",
                    sum,ammount,average,max,min);
            
            ammount ++;
                
        }while(number != -1);
        Console.WriteLine("Bye!");
    }
}
