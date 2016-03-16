// Pedro Antonio Pérez Paterna

using System;
using System.IO;
using System.Net;

public class WebDownload
{
    public static void Main()
    {
        WebClient client = new WebClient();
        
        Stream connection = client.OpenRead("http://www.yahoo.com");
        
        StreamReader reader = new StreamReader(connection);
        
        string line;
        
        while((line = reader.ReadLine()) != null)
            Console.WriteLine(line);
        connection.Close();
    }
}
