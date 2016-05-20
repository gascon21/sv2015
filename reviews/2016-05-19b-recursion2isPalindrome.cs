using System;

public class Recursion2
{
    public static void Main()
    {
        Console.WriteLine(IsPalindrome("asa"));
    }

    public static bool IsPalindrome(string s)
    {
        if (s.Length <= 1)
            return true;

        int len = s.Length;
        return ((s[0] == s[len - 1]) &&
            IsPalindrome(s.Substring(1, len - 2)));
    }

}
