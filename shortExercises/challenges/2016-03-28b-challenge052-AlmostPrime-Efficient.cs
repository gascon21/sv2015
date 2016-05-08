// Tuenti 2015 002
// Nacho C.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class Challenge002
{
    const long MAX = 9999999;
    static List<long> primes;
    static List<long> almostPrimes;
    
    static bool debugging = true;
    static bool measuringTimes = true;


    static void DumpToFile(string text)
    {
        StreamWriter dumpF = File.AppendText("t2.out");
        dumpF.WriteLine(text);
        dumpF.Close();
    }


    public static void GenerateListOfPrimes(long max)  // Sieve of Erasthotenes
    {
        primes = new List<long>();
        //primes.Add(1);
        primes.Add(2);
        int maxSquareRoot = (int)(Math.Sqrt(max));
        BitArray discarded = new BitArray((int)(max + 1));

        for (int i = 3; i <= max; i += 2)
            if (!discarded[i])
            {
                primes.Add(i);
                if (i < maxSquareRoot)
                    for (int j = i * i; j <= max; j += 2 * i)
                        discarded[j] = true;
            }
        if (debugging) Console.WriteLine("Sieve finished");
    }


    public static void GenerateListOfAlmostPrimes(long max)
    {
        almostPrimes = new List<long>();
        int limit = primes.Count;
        for (int i = 0; i < limit; i ++)
            for (int j = 0; j <= i; j ++)
            {
                long n1 = primes[i];
                long n2 = primes[j];
                if (n1 * n2 > MAX)
                    break;
                almostPrimes.Add(n1*n2);
            }
        almostPrimes.Sort();
    }


    public static void ProcessAndDump(int min, int max)
    {        
        if (debugging)
            Console.WriteLine(min+" "+max);
        int pos1 = almostPrimes.BinarySearch(min);
        if (pos1 < 0) 
            pos1 = -pos1 - 1; // If first point not included
        //else
            //;  // First point included
        int pos2 = almostPrimes.BinarySearch(max);
        if (pos2 < 0) 
            pos2 = -pos2 - 1;  // If second point not included
        else
            pos2 ++;  // Second point included
        Console.WriteLine( pos2-pos1 );
    }


    public static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        if (debugging)
            Console.WriteLine("Generating primes...");
        GenerateListOfPrimes(MAX);
        if (debugging)
            Console.WriteLine("{0} primes found.", primes.Count);
            
        if (debugging)
            Console.WriteLine("Generating almost primes...");
        GenerateListOfAlmostPrimes(MAX);
        if (debugging)
            Console.WriteLine("{0} almost primes found.", almostPrimes.Count);
        
        if (debugging)    
        {
            Console.WriteLine("First 10 primes: ");
            for (int i = 0; i < 10; i++)
                Console.Write(almostPrimes[i]+ " ");
        }
                
        if (args.Length > 0)
            Console.SetIn(new StreamReader(args[0]));

        int cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            string details = Console.ReadLine();
            string[] minMax = details.Split(' ');
            ProcessAndDump(
                Convert.ToInt32(minMax[0]), 
                Convert.ToInt32(minMax[1]));
                
            if (measuringTimes)
            {
                Console.WriteLine("Seconds taken so far: {0}", 
                    DateTime.Now - start);
                Console.WriteLine();
            }
        }
    }
}
