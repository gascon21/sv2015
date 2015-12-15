/* Sergio Martínez Mira
 * a program that asks the user for a positive integer number 
 * and displays its equivalent in binary form
 * */

using System;

public class Binary
{
    public static void Main()
    {
        Console.WriteLine("Enter the number1 to convert to Binary: ");
        uint number1 = Convert.ToUInt32(Console.ReadLine());
        int counter = 0;
        uint numbercounter = number1;
        
        if (number1 != 0)
        {
            while (numbercounter >= 1)
            {
                numbercounter /=2;
                counter++;
                
            }

            uint[] binarydata = new uint[counter];
    
            for (int i = 0; i < counter;i++)
            {
                binarydata[i] = number1%2;

                if (number1 == 1)
                    Console.WriteLine("1, finished");
                else
                    Console.WriteLine("{0} : 2 = {1}, remainder {2}",
                        number1, number1/2, binarydata[i]);
                number1 /=2;
            }

            Console.WriteLine();
            for (int i = counter-1; i >= 0; i--)
            {
                Console.Write(binarydata[i]);
            }
            Console.WriteLine();
        }
    }
}
