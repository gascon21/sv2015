// Ruben Blanco
// Program: WebCreator2 (FileInfo)

using System;
using System.IO;
using System.Collections.Generic;

public class WebCreator
{
    public static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo [] fileList = dir.GetFiles("*.*");
        
        StreamWriter myFile = File.CreateText("web2.html");
        myFile.WriteLine("<html>");
        myFile.WriteLine("<body>");
        myFile.WriteLine("<ul>");
        
        foreach(FileInfo file in fileList)
        {
            if ((file.Extension == ".jpg")
                || (file.Extension == ".png"))
            {
                myFile.WriteLine(
                    "<li><a href=\"" + file.Name + " \">" +     
                    file.Name + "</a> ("+
                    file.Length / 1024 + " KB)</li>");
            }
        }
        
        myFile.WriteLine("</ul>");
        myFile.WriteLine("</body>");
        myFile.WriteLine("</html>");
        myFile.Close();
    }
}
