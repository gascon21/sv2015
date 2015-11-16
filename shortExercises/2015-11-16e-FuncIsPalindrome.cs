/* Sergio Martínez Mira
 * A function named "IsPalindrome", which receives an integer number and
 *  retuns true if it is palindrome (can be read from right to left or
 * from left to right), or false if it is not
 * */

using System;

public class FunctionIsPalindrome
{
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
        Console.Write("Enter a number: ");
        int x = Convert.ToInt32( Console.ReadLine() );
        if (IsPalindrome(x))
            Console.WriteLine("It's a palindrome!");
        else
            Console.WriteLine("It's not a palindrome...");
    }
}
