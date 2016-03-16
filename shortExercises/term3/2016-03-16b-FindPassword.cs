// Find a password using brute force
// Clue: The example file has a 4 digits numeric password

using System;
using System.Diagnostics;

public class RunProgram
{
    public static void Main()
    {
        Console.Write("Trying to find password... ");
        for (int i=1000; i<=9999; i++)
        {
            Console.Write(i + " ");
            Process proc = Process.Start("unrar.exe",
                "x g.rar -p" + i.ToString() );
            proc.WaitForExit();
            if (proc.ExitCode == 0)
            {
                Console.WriteLine("Found!");
                break;
            }
        }
    }
}
