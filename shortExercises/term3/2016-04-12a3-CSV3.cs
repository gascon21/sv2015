// CSV, version 3 (complete, but still not checking \" nor inner ";" )

using System;
using System.IO;

public class CSV3
{
    public static int Main(string[] args)
    {
        string fileName;
        
        if (args.Length != 1)
        {
            Console.Write("Enter the name of the CSV file: ");
            fileName = Console.ReadLine();
        }
        else
            fileName = args[0];
            
        if (! File.Exists(fileName))
        {
            Console.WriteLine("File not found");
            return 1;
        }
        
        try
        {
            StreamReader input = new StreamReader(fileName);
            StreamWriter output = new StreamWriter(fileName + ".txt");

            string line;
            do
            {
                line = input.ReadLine();

                if ( line != null ) 
                {
                    if (line.Contains(";"))
                    {
                        string[] parts = line.Split(';');
                        for ( int i = 0; i < parts.Length; i++)
                            output.WriteLine( parts[i].Replace("\"","") );
                        output.WriteLine( );
                    }
                }
            }
            while (line != null);
            input.Close();
            output.Close();

        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            return 2;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/output error: {0}", ex.Message);
            return 3;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
            return 4;
        }
        return 0;
    }
}
