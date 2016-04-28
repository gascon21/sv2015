// Files in subdirectories

using System;
using System.IO;

public class SiteMapGenerator
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
