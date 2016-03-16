// Miguel Moya Ortega
using System;
using System.IO;
using System.Collections.Generic;

public class Directorios
{
    public static void Main()
    {
        List<string> list = new List<string>();
        string dir = ".";
        string[] fileList = Directory.GetFiles(dir, "*.exe");
            foreach(string fileName in fileList)
                list.Add(fileName);
                
        fileList = Directory.GetFiles(dir, "*.bat");
            foreach(string fileName in fileList)
                list.Add(fileName);
                
        fileList = Directory.GetFiles(dir, "*.msi");
            foreach(string fileName in fileList)
                list.Add(fileName);
                
        fileList = Directory.GetFiles(dir, "*.com");
            foreach(string fileName in fileList)
                list.Add(fileName);
                
        fileList = Directory.GetFiles(dir, "*.cmd");
            foreach(string fileName in fileList)
                list.Add(fileName);
                
        list.Sort();            
        foreach(string fileName in list)
        {
            int slashPos = fileName.LastIndexOf("\\");
            Console.WriteLine(fileName.Substring(slashPos+1));
        }
    }
}
