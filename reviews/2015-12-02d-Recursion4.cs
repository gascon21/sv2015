// Contains, recursive version

using System;
public class Recursion4
{
    public static bool Contains(string text, char charToSearch)
    {
        if (text.Length == 0)
            return false;
            
        if (text[0] == charToSearch)
            return true;
            
        return Contains(
            text.Substring(1, text.Length - 1), 
            charToSearch);
    }
    
    
    public static int Main(string[] args)
    {
        Console.WriteLine("Hello contains e? "+ Contains("Hello", 'e'));
        Console.WriteLine("Hello contains a? "+ Contains("Hello", 'a'));
        return 0;
    }
}
