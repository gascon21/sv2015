// SQL Extractor, second approach

using System;
using System.IO;

class SQLextractor2
{
    static void Main()
    {
        StreamReader inFile;
        StreamWriter outFile;
        string line;

        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if(!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        try
        {
            inFile = File.OpenText(fileName);
            outFile = File.CreateText(fileName+".out.txt");
            do
            {
                line = inFile.ReadLine();
                if (line != null)
                    ExtractAndDump(line, outFile);
            } while(line != null);
            inFile.Close();
            outFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Entered path was too long");
            return;
        }
        catch (IOException exp)
        {
            Console.WriteLine("Input/output error: {0}", exp.Message);
            return;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Unexpected error: {0}", exp.Message);
            return;
        }
        Console.WriteLine("Extraction finished");
               
    }
    
    private static void ExtractAndDump(string line, StreamWriter file)
    {
        if (!line.Contains("insert"))
            return;

        // Remove leading part
        line = line.Replace("insert into ", "");

        // Extract name
        int nameEndPos = line.IndexOf(" ");
        string name = line.Substring(0, nameEndPos);
        file.WriteLine(name);

        // Extract field names
        line = line.Substring(nameEndPos + 2);
        int fieldsEndPos = line.IndexOf(")");
        string allFields = line.Substring(0, fieldsEndPos);

        // And extract values
        line = line.Substring(fieldsEndPos + 10);  // ) values (
        line = line.Remove(line.Length - 2);  // );
        string values = line;

        // Split field names
        // Now they are something like "codigo, nombre"
        allFields = allFields.Replace(" ", "");
        string[] fieldNames = allFields.Split(',' );

        // Split values
        // Now they are something like "'a', 'alicante'"
        string[] fieldValues = new string[fieldNames.Length];
        int pos = 0;
        for (int i = 0; i < fieldValues.Length; i++)
        {
            string temp = "";
            if (values[pos] == '\'') // string
            {
                pos++;
                while (values[pos] != '\'') // read till closing quote
                {
                    temp += values[pos];
                    pos++;
                }
                fieldValues[i] = temp;
                pos+=2; // skip comma and space
            }
            else // number
            {
                while ((pos < values.Length) && 
                    (values[pos] != ',')) // read till separating comma or EOL
                {
                    temp += values[pos];
                    pos++;
                }
                fieldValues[i] = temp;
            }

            pos++; // Skip trailing space
        }

        // And display all of them
        for (int i = 0; i < fieldNames.Length; i++)
            file.WriteLine(fieldNames[i] + ": " + fieldValues[i]);

        // Separation blank line
        file.WriteLine();
    }
}
