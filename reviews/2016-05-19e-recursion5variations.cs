// Display all the variations with the letters of a string
// For example: for "asd", result would be
// aaa aas aad asa ass asd ada ads add 
// saa sas sad ssa sss ssd sda sds sdd 
// daa das dad dsa dss dsd dda dds ddd

using System;

public class DisplayVariationsOfString
{
    public static void DisplayVariations(string s)
    {
        DisplayVariationsRec(s, "");
    }
    
    public static void DisplayVariationsRec(
        string s, string part)
    {
        // Base case: all letters processesed
        if (part.Length == s.Length)
        {
            Console.Write(part + " " );
            return;
        }
        
        // General case, process the next sequence
        for (int pos=0; pos<s.Length; pos++)
        {
            char letter = s[pos];
            DisplayVariationsRec(s, part+letter);
        }
        
    }
    
    
    public static void Main()
    {
        DisplayVariations("asd");
    }
}
