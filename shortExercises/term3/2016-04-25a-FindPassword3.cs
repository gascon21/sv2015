// Find a password using brute force
// (Words fetched from a dictionary which is stored in a file)

using System;
using System.IO;
using System.Diagnostics;

public class RunProgram
{
    public static void Main()
    {
        Console.Write("Trying to find password... ");
        StreamReader wordsFile = new StreamReader("UK-dict.txt");
        string line = wordsFile.ReadLine();
        bool found = false;
        while ((line != null) && (!found))
        {
            Console.Write(line + " ");
            Process proc = Process.Start("7za.exe",
                "x 64.zip -y -p" + line );
            proc.WaitForExit();
            if (proc.ExitCode == 0)
            {
                Console.WriteLine("Found!  " + line);
                found = true;
            }
            line = wordsFile.ReadLine();
        }
        wordsFile.Close();
    }
}
