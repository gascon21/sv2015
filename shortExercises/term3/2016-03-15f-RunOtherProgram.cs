//Sergio Martínez Mira

using System;
using System.Diagnostics;

public class RunProgram
{
    public static void Main()
    {
        Process proc = Process.Start("notepad.exe");
        proc.WaitForExit();
    }
}
