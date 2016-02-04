// First example of exhaustive search

using System;

public class Exhaustive
{
    public static void DisplayPermutations(
        string currentText, string remaining)
    {
        // Base case
        if (remaining == "")
            Console.WriteLine(currentText);        
        // General case
        else
        {
            for (int i=0; i<remaining.Length; i++)
            {
                DisplayPermutations(
                    currentText + remaining.Substring(i,1),
                    remaining.Remove(i, 1) );
            }
        }
    }
    
    public static void Main()
    {
        DisplayPermutations("", "BYE");
    }
}
