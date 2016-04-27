// Is Valid Identifier? (V2: Regex)

using System;
using System.Text.RegularExpressions;

public class Regex1
{
    public static void Main(string[] args)
    {
        bool debugging = true;
        
        if (debugging)
        {
            Console.WriteLine("a123:" + IsValidIdentifier("a123"));
            Console.WriteLine("1a23:" + IsValidIdentifier("1a23"));
            Console.WriteLine("bacd:" + IsValidIdentifier("bacd"));
            Console.WriteLine("bac?:" + IsValidIdentifier("bac?"));
        }
        
        Console.Write("Variable? ");
        string name = Console.ReadLine();

        if (IsValidIdentifier(name))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Not valid");
    }

    public static bool IsValidIdentifier(string variable)
    {
        Regex pattern = new Regex(@"\A[a-zA-Z][0-9a-zA-Z]*\z");
        if (pattern.IsMatch(variable))
            return true;
        else
            return false;
    }
}
