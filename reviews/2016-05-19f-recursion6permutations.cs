// Display all the permutations with the letters of a string
// For example: for "asd", result would be
// asd ads sad sda das dsa

using System;

public class DisplayPermutationsOfString
{
    public static void DisplayPermutations(string s)
    {
        DisplayPermutationsRec(s, "");
    }
    
    public static void DisplayPermutationsRec(
        string remaining, string processed)
    {
        // Base case: no more letters to process
        if (remaining.Length == 0)
        {
            Console.Write(processed + " " );
            return;
        }
        
        // General case, remove each letter and process the next sequence
        for (int pos=0; pos<remaining.Length; pos++)
        {
            char letter = remaining[pos];
            string others = remaining.Remove(pos,1);
            DisplayPermutationsRec(others, processed+letter);
        }
        
    }
    
    
    public static void Main()
    {
        DisplayPermutations("asd");
    }
}
