/*
    Sacha Van de sijpe
    Odd or even Switch
*/

using System;

public class OddEvenSwitch
{
    public static void Main()
    {
        int number;
        
        Console.Write("Enter a number between 1 and 10: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        switch (number)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 9:
                Console.WriteLine("Odd!");
                break;
            case 2:
            case 4:
            case 6:
            case 8:
            case 10:
                Console.WriteLine("Even");
                break;
            default:
                Console.WriteLine("Not a valid number");
                break;
        }
    }
}
