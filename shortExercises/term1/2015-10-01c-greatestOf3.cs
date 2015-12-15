using System;

public class GreatestOf3
{
    public static void Main()
    {
        int number1, number2, number3;

        Console.Write("Enter the 1st number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the 2nd number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the 3rd number: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        if ((number1 >= number2) && (number1 >= number3))
            Console.WriteLine("The greatest is: {0}", number1);
        else if ((number2 >= number1) && (number2 >= number3))
            Console.WriteLine("The greatest is: {0}", number2);
        else
            Console.WriteLine("The greatest is: {0}", number3);
    }
}
