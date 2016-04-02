// Gonzalo García Soler
// Challenge 56: All your base
// https://code.google.com/codejam/contest/189252/dashboard#s=p0

// Note: this is not a totally correct solutions.
// It works ok with cases such as: 11001001 cats zig hahaha
// But fails with others such as: 111111111 z howareyou gentlemen

using System;
using System.Collections;
using System.IO;

public class AllYourBase
{
    public static long MinBaseNumber(long nBase)
    {
        string stringNumber = "10";
        for (long i = 2; i < nBase; i++)
            stringNumber += i.ToString();

        return Convert.ToInt64(stringNumber);
    }

    public static long CalculateBase(string input)
    {
        ArrayList charList = new ArrayList();
        for (int i = 0; i < input.Length; i++)
        {
            if (!charList.Contains(input[i]))
                charList.Add(input[i]);
        }
        return charList.Count;
    }

    public static void Main()
    {
        StreamWriter outFile = File.CreateText("output.txt");

        long cases = Convert.ToInt64(Console.ReadLine());

        for (long i = 1; i <= cases; i++)
        {
            string input = Console.ReadLine();
            long nBase = CalculateBase(input);

            if (nBase != 2)
            {
                long result = 0;
                string minNumberBase = MinBaseNumber(nBase).ToString();

                long multiplier = 1;

                char[] numbersReversed = minNumberBase.ToCharArray();
                Array.Reverse(numbersReversed);

                for (long accountant = 0; accountant < nBase; accountant++)
                {
                    long currentNumber =
                        Convert.ToInt64(numbersReversed[accountant].ToString());
                    result += multiplier * currentNumber;
                    multiplier *= nBase;
                }

                outFile.WriteLine("Case #" +i + ": "+result);
            }
            else if ((!input.Contains("1")) && (!input.Contains("0")))
            {
                string output = "";
                for (long accountant = 0; accountant < input.Length / 2; accountant++)
                    output += "10";

                outFile.WriteLine("Case #" + i + ": " + Convert.ToInt64(output, 2).ToString());
            }
            else
            {
                outFile.WriteLine("Case #" + i + ": "+Convert.ToInt64(input, 2).ToString());
            }
        }
        outFile.Close();
    }
}
