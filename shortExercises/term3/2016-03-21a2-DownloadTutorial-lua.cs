// Website downloader (example: Lua book)

using System;
using System.IO;
using System.Net;

public class BookDownloader
{
    public static void LoadPage(string url, WebClient client)
    {
        Stream s = client.OpenRead(url);
        StreamReader sr = new StreamReader(s);
        StreamWriter sw = new StreamWriter("LuaBook.html", true); 
        string line = sr.ReadLine();
        while (line != null)
        {
            sw.WriteLine(line);
            line = sr.ReadLine();
        }
        s.Close();
        sr.Close();
        sw.Close();
    }
    
    public static void Main()
    {
        string url = "http://www.lua.org/pil/contents.html";
        WebClient client = new WebClient();
        Stream s = client.OpenRead(url);
        StreamReader sr = new StreamReader(s);
        string line = sr.ReadLine();
        while (line != null)
        {
            if (line.Contains(" href="))
            {
                int startQuotes = line.IndexOf(" href=") + 7;
                int endQuotes = line.IndexOf("\"", startQuotes+1);
                string href = line.Substring( startQuotes, 
                    endQuotes-startQuotes);
                Console.WriteLine(href);
                string downloadUrl = "http://www.lua.org/pil/"+href;
                LoadPage(downloadUrl, client);
            }
            line = sr.ReadLine();
        }
        s.Close();
        sr.Close();
    }
}
