// CSV, version 1 (simplified)

using System;
using System.IO;

public class CSV1
{
    public static void Main(string[] args)
    {
        string fileName = "gente.csv";

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
}
