// Miguel Moya Ortega

using System;
using System.IO;

public class ConverterToHtml
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        string line = "";
        bool list = false;
        bool p = false;
        
        if (File.Exists(fileName))
        {
            StreamReader file = File.OpenText(fileName);
            StreamWriter file2 = File.CreateText(fileName + ".html");
            
            
                file2.WriteLine("<!DOCTYPE>");
                file2.WriteLine("<html>");
                file2.WriteLine("<head>");
                file2.WriteLine("    <title> Converted html </title>");
                file2.WriteLine("</head>");
                file2.WriteLine("<body>");
                
            do
            {
                line = file.ReadLine();
                if (line != null)
                {
                    line = line.Trim();
                    if (list && line == "")
                    {
                        file2.WriteLine("</ul>");
                        list = !list;
                    }
                    if (p && line == "")
                    {
                        file2.WriteLine("</p>");
                        p = !p;
                    }
                    if (line == "")
                    {
                    }
                    else if(line[0] == '#' && line[1] != '#')
                        file2.WriteLine("<h1>" + line.Substring(1) + "</h1>");
                    else if (line[0] == '#' && line[1] == '#')
                        file2.WriteLine("<h2>" + line.Substring(2) + "</h2>");
                    else if( line[0] == '-')
                    {
                        if (!list)
                        {
                            file2.WriteLine("<ul>");
                            list = !list;
                        }
                        file2.WriteLine("    <li>" + line.Substring(1)
                                + "</li>");
                    }
                    else
                    {
                        if (!p)
                        {
                            file2.WriteLine("<p>");
                            p = !p;
                        }
                        file2.WriteLine("    " + line);
                    }
                }
            }
            while (line != null);
            
            file2.WriteLine("</body>");
            file2.WriteLine("</html>");
            
            file.Close();
            file2.Close();
        }
        else
            Console.WriteLine("The file doesn't exist.");
    }
}
