using System;

public class RecursivePalindrome
{
    public static void Main()
    {
        for (int i = 0; i < 25000; i++)
            if ( IsPalindrome(Convert.ToString(i)) )
                Console.Write("{0} ", i);
    }
    
    
    public static bool IsPalindrome(string text)
    {
        // Base case: 1 or less characters
        if (text.Length <= 1)  
            return true;
        else
        // General case: the first and char must be the same
        // and the middle substring must be a palindrome, too
        { 
            if (text[0] != text[text.Length-1])
                return false;
            else
                return IsPalindrome(text.Substring(1, text.Length-2));
        }
    }
}

