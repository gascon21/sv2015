// Vicente Cuenca Reyes
// Multiplication table

using System;

public class Multiplicationtable
{
    public static void Main()
    {
        int Number;
        
        Console.WriteLine("Enter the number");
        Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} x 0 = {1}", Number, Number*0);
        Console.WriteLine("{0} x 1 = {1}", Number, Number*1);
        Console.WriteLine("{0} x 2 = {1}", Number, Number*2);
        Console.WriteLine("{0} x 3 = {1}", Number, Number*3);
        Console.WriteLine("{0} x 4 = {1}", Number, Number*4);
        Console.WriteLine("{0} x 5 = {1}", Number, Number*5);
        Console.WriteLine("{0} x 6 = {1}", Number, Number*6);
        Console.WriteLine("{0} x 7 = {1}", Number, Number*7);
        Console.WriteLine("{0} x 8 = {1}", Number, Number*8);
        Console.WriteLine("{0} x 9 = {1}", Number, Number*9);
        Console.WriteLine("{0} x 10 = {1}",Number, Number*10);
    }
}
