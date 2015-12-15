// Miguel Moya Ortega

// Timed results:
// n = 600 000, first algorithm: 3.03.924, AMD A10 6800B 4.1GHz

using System;

public class PalindromeAndPrimes
{
    public static bool IsPrime(int n)
    {
        int dividers = 0;
        int i = 1;
        while ((i <= n) && (dividers <= 2))
        {
            if (n % i == 0)
                dividers++;
            i++;
        }

        if (dividers == 2)
            return true;
        else
            return false;
    }
    public static bool IsPalindrome(int n)
    {
        string number = Convert.ToString(n);
        int left = 0;
        int right = number.Length - 1;
        while (left < right)
        {
            if (number[left] != number[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        bool debugging = true;
        DateTime start = DateTime.Now;
        
        while (!(IsPrime(n)) || !(IsPalindrome(n)))
            n++;
        Console.WriteLine(n);
        
        if (debugging)
        {
            DateTime end = DateTime.Now;
            Console.WriteLine("Time used = {0}", end-start);
        }
    }
}
