// Jorge Montalvo
// Multiple of Seven?

using System;

public class MultipleOfSeven
{
    public static void Main()
    {
        int number;
        
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        while (number > 0)
        {
            if(number % 7 == 0)
                Console.WriteLine("It is a multiple of 7");
            else
                Console.WriteLine("It is not a multiple of 7");
                
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Bye!");
    }
}
