// Chen Chao
// 25-04-2016

using System;
using System.IO;

public class SiteMapGenerator
{
    public static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo[] file = dir.GetFiles(); 
        StreamWriter outFile = new StreamWriter("sitemap.xml");
        string header = "http://www.tpn.com/";
        outFile.WriteLine("<?xml version = \"1.0\" encoding=\"UTF-8\"?>");
        outFile.WriteLine("<urlset xmlnl=\"http://sitemaps.org/schemas/sitemap/0.9\">");
        for (int i = 0; i < file.Length; i++)
        {
            if (file[i].Name.EndsWith(".html"))
            {
                outFile.WriteLine("<url>");
                outFile.WriteLine("  <loc>" + header + file[i].Name + "</loc>");
                outFile.WriteLine("  <lastmod>" + 
                    file[i].LastWriteTime.ToString().Split()[0] + "</lastmod>");
                outFile.WriteLine("  <changefreq>monthly</changefreq>");
                outFile.WriteLine("</url>");
                outFile.WriteLine();
            }  
        }

        outFile.WriteLine("</urlset>");
        outFile.Close();
    }
} 
