// Files in subdirectories
// V2: GetFileSystemInfos

using System;
using System.IO;

public class FilesInSubdirectories2
{
    public static void ShowDirectory(string name)
    {
        DirectoryInfo dir = new DirectoryInfo(name);
        FileSystemInfo[] file = dir.GetFileSystemInfos();
        for (int i = 0; i < file.Length; i++)
        {
            Console.WriteLine(file[i].FullName);
            if ((file[i].Attributes & FileAttributes.Directory) != 0)
                ShowDirectory(file[i].FullName);
        }
    }

    public static void Main()
    {
        ShowDirectory(".");
    }
}
