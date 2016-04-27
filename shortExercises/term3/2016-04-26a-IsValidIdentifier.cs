// Is Valid Identifier?
using System;

public class ValidIdentifier
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

    public static bool IsValidIdentifier(string name)
    {
        name = name.ToUpper();
        
        if (! ((name[0] >= 'A') && (name[0] <= 'Z')))
            return false;
            
        // if ((name[0] < 'A') || (name[0] > 'Z')))
        //    return false;
            
        for (int i = 1; i < name.Length; i++)
            if (!(name[i] >= '0' && name[i] <= '9') 
                    && !(name[i] >= 'A' && name[i] <= 'Z'))
                return false;

        return true;
    }
}
