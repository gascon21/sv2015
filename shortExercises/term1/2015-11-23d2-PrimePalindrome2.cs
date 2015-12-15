// Palindromic Prime (palprime)
// Timed results:
// n = 600 000, first algorithm: 3' 03.924"
// n = 600 000, second algorithm: < 0' 0.2"

using System;

public class PalindromeAndPrimes
{
    public static bool IsPrime(int n)
    {
        if (n < 4)
            return true;
        if (n % 2 == 0)
            return false;
        
        int i = 3;
        while (i <= n/2)
        {
            if (n % i == 0)
                return false;
            i += 2;
        }

        return true;
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
        
        while (!(IsPalindrome(n)) || !(IsPrime(n)))
            n++;
        Console.WriteLine(n);
        
        if (debugging)
        {
            DateTime end = DateTime.Now;
            Console.WriteLine("Time used = {0}", end-start);
        }
    }
}
