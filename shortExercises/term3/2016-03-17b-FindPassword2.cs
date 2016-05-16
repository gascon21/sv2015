// Find a password using brute force (version 2)
// Clue: The example file has a password between 4 and 9 characters 
//   from a to z (lowercase), taken from the name "adrian"

using System;
using System.Diagnostics;

public class FindPassword
{
    public static void Main()
    {
        for (int length=4; length<10; length++)
            GenerateAndTry("", length, "adrin", "g.7z");
    }

    public static void GenerateAndTry(
        string currentText, int length, string alphabet, string filename)
    {
        // Base case
        if (currentText.Length == length)
        {
            Console.Write(currentText+"  ");        
            Process proc = Process.Start("7za.exe",
                "x "+filename+ " -p" + currentText );
            proc.WaitForExit();
            if (proc.ExitCode == 0)
            {
                Console.WriteLine("Found!");
                Environment.Exit(0);
            }
        }
        // General case
        else
        {
            for (int i=0; i<alphabet.Length; i++)
            {
                GenerateAndTry(
                    currentText + alphabet.Substring(i,1),
                    length, alphabet, filename );
            }
        }
    }


}
