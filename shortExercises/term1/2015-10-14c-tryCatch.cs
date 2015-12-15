// First example of try - catch
using System;

public class TryCatch
{
    public static void Main()
    {
        int a, b;

        try
        {
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The division is {0}", a / b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid number!");
        }
    }
}
