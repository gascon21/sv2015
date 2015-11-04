// Sum digits

/*
Input

3433
64323
8
-1

Output

3 + 4 + 3 + 3 = 13
6 + 4 + 3 + 2 + 3 = 18
8 = 8
*/

using System;

public class SumDigits
{
    public static void Main()
    {
        string number;
        
        do
        {            
            number = Console.ReadLine();
            long sum = 0;
            if (number != "-1")
            {
                int size = number.Length;               
                Console.Write(number[0]);
                sum += number[0] - '0';
                for (int i = 1; i < size; i++)
                {
                    Console.Write(" + ");
                    Console.Write(number[i]);
                    sum += number[i] - '0';
                }
                Console.Write(" = ");
                Console.WriteLine(sum);
            }            
        }
        while (number != "-1");
    }
}
