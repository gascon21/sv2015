// Guess the number

using System;

public class Guess
{
    public static void Main()
    {
        int number;
        int answer=44;
        
        do
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            if (number < answer)
                Console.WriteLine("Answer is bigger");
            else if (number > answer)
                Console.WriteLine("Answer is smaller");
                
        }
        while (number != answer);
        
        Console.WriteLine("Correct!");
    }
}
