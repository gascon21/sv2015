// Ruben Blanco
// Program: DownloadWebsitesToFilesV2
// Downloading LUA Manual

using System;
using System.IO;
using System.Net;

public class DownloadWebsitesToFiles
{
    public static void Main()
    {
        WebClient client = new WebClient();
        Stream connection = client.OpenRead
            ("http://www.lua.org/manual/5.1/es/manual.html");
        StreamReader reader = new StreamReader(connection);
        Console.WriteLine("Opening intro");
        
        StreamWriter myFile = new StreamWriter("LuaManual.html");
        
        string line;
     
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        connection = client.OpenRead
            ("http://www.lua.org/manual/5.1/es/manual.html#2");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening 2");
        
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        for (int i = 1; i <=11; i++)
        {
            connection = client.OpenRead
                ("http://www.lua.org/manual/5.1/es/manual.html#2." + i);
            reader = new StreamReader(connection);
            Console.WriteLine("Opening html 2.{0}", i);
            
            while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
                
                
            if (i == 2)
            {
                connection = client.OpenRead
                ("http://www.lua.org/manual/5.1/es/manual.html#2.2.1");
                reader = new StreamReader(connection);
                Console.WriteLine("Opening html 2.2.1");
        
                while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
            }
            
            if (i == 4)
            {
                for (int j = 1; j <=7; j++)
                {
                    connection = client.OpenRead
                        ("http://www.lua.org/manual/5.1/es/manual.html#2.4." + j);
                    reader = new StreamReader(connection);
                    Console.WriteLine("Opening html 2.4.{0}", j);
                    
                    while((line = reader.ReadLine()) != null)
                        myFile.WriteLine(line);
                }
            }
            
            if (i == 5)
            {
                for (int j = 1; j <=9; j++)
                {
                    connection = client.OpenRead
                        ("http://www.lua.org/manual/5.1/es/manual.html#2.5." + j);
                    reader = new StreamReader(connection);
                    Console.WriteLine("Opening html 2.5.{0}", j);
                    
                    while((line = reader.ReadLine()) != null)
                        myFile.WriteLine(line);
                }
            }
            
            if (i == 10)
            {
                for (int j = 1; j <=2; j++)
                {
                    connection = client.OpenRead
                        ("http://www.lua.org/manual/5.1/es/manual.html#2.10." + j);
                    reader = new StreamReader(connection);
                    Console.WriteLine("Opening html 2.10.{0}", j);
                    
                    while((line = reader.ReadLine()) != null)
                        myFile.WriteLine(line);
                }
            }
        }
        
        for (int i = 1; i <=8; i++)
        {
            connection = client.OpenRead
                ("http://www.lua.org/manual/5.1/es/manual.html#3." + i);
            reader = new StreamReader(connection);
            Console.WriteLine("Opening html 3.{0}", i);
            
            while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
        }
        
        connection = client.OpenRead
            ("http://www.lua.org/manual/5.1/es/manual.html#4");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening 4");
        
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        connection = client.OpenRead
            ("http://www.lua.org/manual/5.1/es/manual.html#4.1");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening html 4.1");
        
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        for (int i = 1; i <=9; i++)
        {
            connection = client.OpenRead
                ("http://www.lua.org/manual/5.1/es/manual.html#5." + i);
            reader = new StreamReader(connection);
            Console.WriteLine("Opening html 3.{0}", i);
            
            while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
                
            if (i == 4)
            {
                connection = client.OpenRead
                ("http://www.lua.org/manual/5.1/es/manual.html#5.4.1");
                reader = new StreamReader(connection);
                Console.WriteLine("Opening html 5.4.1");
        
                while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
            }
        }
        
        connection = client.OpenRead
            ("http://www.lua.org/manual/5.1/es/manual.html#6");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening 6");
        
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        for (int i = 1; i <=3; i++)
        {
            connection = client.OpenRead
                ("http://www.lua.org/manual/5.1/es/manual.html#7." + i);
            reader = new StreamReader(connection);
            Console.WriteLine("Opening html 7.{0}", i);
            
            while((line = reader.ReadLine()) != null)
                myFile.WriteLine(line);
        }
        
        connection = client.OpenRead
            ("http://www.lua.org/manual/5.1/es/manual.html#8");
        reader = new StreamReader(connection);
        Console.WriteLine("Opening 8");
     
        while((line = reader.ReadLine()) != null)
            myFile.WriteLine(line);
        
        connection.Close();
        reader.Close();
        myFile.Close();
    }
}
