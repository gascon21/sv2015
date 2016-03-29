// Gonzalo García Soler
// Challenge 52: Almost prime, brute force version

using System;
using System.IO;  // For StreamReader

public class AlmostPrime
{
    public static bool IsAlmostPrime(int number)
    {
        int divider = 2;
        int primeFactor = 0;

        while (number > 1)
        {
            if (primeFactor > 2)
                return false;

            while (number % divider == 0)
            {
                if (IsPrime(divider))
                    primeFactor++;
                number /= divider;
            }
            divider++;
        }

        return primeFactor == 2 ? true : false;
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

    public static void Main(string[] args)
    {
        // Let's read from file, to automtaize tests
        if (args.Length > 0)
            Console.SetIn( new StreamReader(args[0]) );
        
        // And let's measure times, in order to be able to improve
        DateTime start = DateTime.Now;
        bool debugging = true;
        
        // Now, let's solve the real problem
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            int result = 0;

            string sentence = Console.ReadLine();
            
            if (debugging)
                Console.WriteLine("Testing: {0}", sentence);
                
            string[] numberString = sentence.Split(' ');

            int n1 = Convert.ToInt32(numberString[0]);
            int n2 = Convert.ToInt32(numberString[1]);

            for (int number = n1; number <= n2; number++)
            {
                if ( !IsPrime(number) && IsAlmostPrime(number) )
                    result++;
                
            }

            Console.WriteLine(result);
            
            if (debugging)
            {
                Console.WriteLine("Seconds taken so far: {0}", 
                    DateTime.Now - start);
                Console.WriteLine();
            }

        }
    }
}
