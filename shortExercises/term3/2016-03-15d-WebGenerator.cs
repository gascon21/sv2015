// Ruben Blanco
// Program: WebCreator

using System;
using System.IO;
using System.Collections.Generic;

public class WebCreator
{
    public static void Main()
    {
        List<string> list = new List<string>();
        string dir = ".";
        string [] fileList = Directory.GetFiles(dir, "*.jpg");
            foreach(string fileName in fileList)
                list.Add(fileName);
                
        fileList = Directory.GetFiles(dir, "*.png");
            foreach(string fileName in fileList)
                list.Add(fileName);
        
        list.Sort();
        
        StreamWriter myFile = File.CreateText("web.html");
        myFile.WriteLine("<html>");
        myFile.WriteLine("<body>");
        myFile.WriteLine("<ul>");
        
        foreach(string fileName in list)
        {
            int slashPos = fileName.LastIndexOf("\\");
            myFile.WriteLine("<li><a href=\"" + 
                fileName.Substring(slashPos+1) +
                " \">" + fileName.Substring(slashPos+1) +
                "</a></li>");
                
        }
        
        myFile.WriteLine("</ul>");
        myFile.WriteLine("</body>");
        myFile.WriteLine("</html>");
        myFile.Close();
    }
}
