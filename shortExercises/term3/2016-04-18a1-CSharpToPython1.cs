// Basic C# to Python converter, first approach

using System;
using System.IO;

public class CSharpToPhyton1
{
    public static void Main(string[] args)
    {
        StreamReader myReader;
        StreamWriter myWriter;
        string fileName="";
        string fileName2="";
        string line = "";

        Console.WriteLine("Enter the C# file to convert: ");
        fileName = Console.ReadLine();

        Console.WriteLine("Enter the Python file to create: ");
        fileName2 = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The C# file doesn't exist.");
            return;
        }

        myReader = new StreamReader(fileName);
        myWriter = new StreamWriter(fileName2);

        do
        {
            line = myReader.ReadLine();
            if (line != null)
            {
                // We must ignore class, using, main and curly braces
                if (line.Trim().StartsWith("public class"))
                    line = "";
                if (line.Trim().StartsWith("class"))
                    line = "";
                if (line.Trim().StartsWith("using "))
                    line = "";
                if (line.Contains("public static void Main()"))
                    line = "";
                if (line.Trim()== "{")
                    line = "";
                if (line.Trim()== "}")
                    line = "";
                // Let's ignore also declarations
                // (dangerous: what if it has a starting value?)
                if (line.Trim().StartsWith("int "))
                {
                    line = "";
                }
                
                // if -> no curly braces, must end with ":"
                if (line.Contains(" if(") || line.Contains(" if ("))
                {
                    line = line.Replace("(", "");  // (Dangerous)
                    line = line.Replace(")", ":");
                }
                
                // else -> :
                if (line.Trim() == "else")
                {
                    line += ":";
                }
                
                // Parameter for WriteLine -> .format
                if ((line.Contains("{0}")) && (line.Contains("\",")))
                {
                    line = line.Replace("\",", "\".format(");
                    if (line.EndsWith(");"))
                        line = line.Replace(");", "))");
                }

                // Simplistic solution for "WriteLine" and "Write":
                // blind replaces
                if (line.Contains("Console.WriteLine")
                    || line.Contains("Console.Write"))
                {
                    line = line.Replace("Console.WriteLine", "print");
                    line = line.Replace("Console.Write","print");
                }

                // for: from C format to "range"
                if (line.Contains("for"))
                {
                    // To do
                }

                // No semicolons
                line = line.TrimEnd();
                if (line.EndsWith(";"))
                    line = line.Substring(0, line.Length-1);

                // User input
                line = line.Replace("Convert.ToInt32", "int");
                line = line.Replace("Console.ReadLine", "input");

                // And let's dump only the non-empty lines
                if (line.Trim() != "")
                {
                    // Let's remove the first tab (class)
                    if (line.Substring(0,8) == "        ")
                        line = line.Substring(8);
                    // And finally, let's dump
                    myWriter.WriteLine(line);
                }
            }
        } while (line != null);

        myReader.Close();
        myWriter.Close();
        Console.WriteLine("Finished");
    }
}

