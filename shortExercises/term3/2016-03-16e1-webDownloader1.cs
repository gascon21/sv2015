// Download a website
// Sergio

using System;
using System.IO;
using System.Net;

public class SavePage
{
    public static void Main()
    {
        string exline = "";
        StreamWriter exwriter = File.CreateText
            ("pythonthehardway-exercises.html");

        WebClient exclient = new WebClient();
        for (int i = 0; i <= 52; i++)
        {
            Stream exconnection = exclient.OpenRead
                ("http://learnpythonthehardway.org/book/ex"+i+".html");
            StreamReader exreader = new StreamReader(exconnection);
            do
            {
                exline = exreader.ReadLine();
                if(exline != null)
                    exwriter.WriteLine(exline);
            }
            while(exline != null);
            exconnection.Close();
            exreader.Close();
        }
        Console.WriteLine("Done!");
    }
}
