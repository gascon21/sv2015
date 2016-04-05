// Gonzalo García Soler
// Challenge 57: Primacity

/*

Amount of numbers between A and B with primacity P:

Example input
5
5 15 2
2 10 1
24 42 3
1000000 1000000 1
1000000 1000000 2

Example output

Case #1: 5
Case #2: 7
Case #3: 2
Case #4: 0
Case #5: 1

*/

using System;
using System.Collections;

public class Primacity
{
    public static bool HasTheNumberPrimacity(int number, int primacity)
    {
        ArrayList primeFactors = new ArrayList();
        int divider = 2;

        while (number > 1)
        {
            if (primeFactors.Count > primacity)
                return false;
            
            while (number % divider == 0)
            {
                if (IsPrime(divider) && !primeFactors.Contains(divider))
                    primeFactors.Add(divider);
                number /= divider;
            }
            divider++;
        }
        return primeFactors.Count == primacity ? true : false;
    }

    public static bool IsPrime(int number)
    {
        int dividers = 0;
        
        for (int i = 1; i <= number; i++)
        {
            if (dividers > 2)
                return false;
            else if (number % i == 0 )
                dividers++;
        }

        return dividers == 2 ? true : false;
    }

    public static void Main()
    {
        DateTime start = DateTime.Now;
        bool debugging = false;
        
        int result;     
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cases; i++)
        {
            result = 0;

            string input = Console.ReadLine();
            string[] dataString = input.Split();
            int[] data = new int[dataString.Length];

            for (int j = 0; j < dataString.Length; j++)
                data[j] = Convert.ToInt32(dataString[j]);

            for (int number = data[0]; number <= data[1]; number++)
                if (HasTheNumberPrimacity(number, data[2]))
                    result++;
            
            Console.WriteLine("Case #{0}: {1}",i,result);
            
            if (debugging)
            {
                Console.WriteLine("Finished at: " + System.DateTime.Now);
                Console.WriteLine("Seconds taken : {0}", DateTime.Now - start);
                Console.WriteLine();
            }
        }
    }
}
