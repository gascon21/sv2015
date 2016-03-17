// Ruben Blanco
// Program: DownloadWebsitesToFiles

using System;
using System.IO;
using System.Net;

public class DownloadWebsitesToFiles
{
    public static void Main()
    {
        WebClient client = new WebClient();
        Stream connection = client.OpenRead
            ("http://learnpythonthehardway.org/book/intro.html");
        StreamReader reader = new StreamReader(connection);
        Console.WriteLine("Opening intro");
        
        StreamWriter myFile = new StreamWriter("pythonManual.html");
        
        string line;
     
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        for (int i = 0; i <=52; i++)
        {
            
            connection = client.OpenRead
                ("http://learnpythonthehardway.org/book/ex" + i +".html");
            reader = new StreamReader(connection);
            Console.WriteLine("Opening html {0}", i);
            
            while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
        }
        
        connection = client.OpenRead
            ("http://learnpythonthehardway.org/book/advice.html");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening advice");
        
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
            
        connection = client.OpenRead
            ("http://learnpythonthehardway.org/book/next.html");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening next steps");
     
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        connection = client.OpenRead
            ("http://learnpythonthehardway.org/book/appendixa.html");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening apenndix A");
     
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        connection.Close();
        reader.Close();
        myFile.Close();
    }
}
