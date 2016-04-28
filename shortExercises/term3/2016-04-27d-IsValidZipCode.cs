// Is Valid ZipCode?

using System;
using System.Text.RegularExpressions;

public class ValidIdentifier
{
    public static void Main(string[] args)
    {
        Console.Write("ZIP Code? ");
        string code = Console.ReadLine();

        if (IsValidZipCode(code))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Not valid");
    }

    public static bool IsValidZipCode(string c)
    {
        if (c.Length != 5)
            return false;
            
        if (! ((c[0] >= '0') && (c[0] <= '5')))
            return false;
        
        for (int i=1; i<=4; i++)
            if (! ((c[0] >= '0') && (c[0] <= '9')))
                return false;
        
        return true;
    }
    
    
    public static bool IsValidZipCodeAlternate(string c)
    {
        if (c.Length != 5)
            return false;
            
        try
        {
            int n = Convert.ToInt32(c);
            if ((n < 1) || (n > 51000))
                return false;
        }
        catch
        {
            return false;
        }

        return true;
    }
    
    public static bool IsValidZipCodeRE(string variable)
    {
        Regex pattern = new Regex(@"\A[0-5][0-9][0-9][0-9][0-9]*\z");
        if (pattern.IsMatch(variable))
            return true;
        else
            return false;
    }
    
    public static bool IsValidZipCodeRE2(string variable)
    {
        Regex pattern = new Regex(@"\A[0-5][0-9]{4}*\z");
        if (pattern.IsMatch(variable))
            return true;
        else
            return false;
    }
    
}
