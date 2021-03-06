﻿// Files in subdirectories
// V1: GetFiles + GetDirectories

using System;
using System.IO;

public class FilesInSubdirectories1
{
    public static void ShowDirectory(string name)
    {
        DirectoryInfo dir = new DirectoryInfo(name);
        FileInfo[] file = dir.GetFiles();
        for (int i = 0; i < file.Length; i++)
        {
            Console.WriteLine(file[i].FullName);
        }

        DirectoryInfo[] directories = dir.GetDirectories();
        for (int i = 0; i < directories.Length; i++)
        {
            ShowDirectory(directories[i].FullName);
        }
    }
    public static void Main()
    {
        ShowDirectory(".");
    }
}
