// CSV, version 2 (also simplified)

using System;
using System.IO;

public class CSV2
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
            if (line != null)
            {
                line = line.Replace("\"","");
                output.WriteLine( line.Replace(";","\n") );
                output.WriteLine( );
            }
        }
        while (line != null);
        input.Close();
        output.Close();
    }
}
