using System;

public class FibonacciNumber
{
    public static void Main()
    {
        int numberfibonacci1 = 0;
        int numberfibonacci2 = 1;
        int number;
        int sum = 0;
        
        Console.Write("Number of fibonacci: ");
        number = Convert.ToInt32(Console.ReadLine());
        int cont = number;
        
        if (number == 0)
            Console.WriteLine("Your number in fibonacci succesion is {0}",
                numberfibonacci1);
        else if (number == 1)
            Console.WriteLine("Your number in fibonacci succesion is {0}",
                numberfibonacci2);
        else
        {
            for (int i = 2; i <= cont; i++)
            {
                sum = numberfibonacci1 + numberfibonacci2;
                numberfibonacci1 = numberfibonacci2;
                numberfibonacci2 = sum;
            }
            Console.WriteLine("Your number in fibonacci succesion is {0}",
                numberfibonacci2);
            Console.WriteLine("The relation with the previous number is {0}",
                (double) numberfibonacci2 / numberfibonacci1);
        }
    }
}
