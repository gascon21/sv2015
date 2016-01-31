/*
Create a simple C# to C++ Converter. In this first approach, it must 
accept a program like this

using System;

public class Sum
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int n1 = Convert.ToIn32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int n2 = Convert.ToIn32(Console.ReadLine());

        Console.WriteLine( n1 + n2 );
    }
}

and generate a file like this

#include <iostream>
using namespace std;

int main()
{
    cout << "Enter the first number: ";
    int n1;
    cin >> n1;
    cout << "Enter the second number: ";
    int n2;
    cin >> n2;

    cout << n1 + n2 << endl;
    return 0;
}

*/

using System.IO;
using System;

class CsharpToCpp
{
    static void Main(string[] args)
    {
        StreamReader inputFile;
        StreamWriter outputFile;
        string line;
        string name;

        if (args.Length < 1)
        {
          Console.WriteLine("Not enough parameters!");
          Console.Write("Enter file name: ");
          name = Console.ReadLine();
        }
        else
          name = args[0];

        if (!File.Exists( name ))
        {
          Console.WriteLine( "File not found!");
          return;
        }

        try
        {
            inputFile = File.OpenText(name);
            outputFile = File.CreateText(
                name.Substring(0, name.Length-3) + ".cpp");
                
            outputFile.WriteLine("#include <iostream>");
            outputFile.WriteLine("using namespace std;");

            do {

                line = inputFile.ReadLine();
                if (line != null)
                {
                    // Common structures not to be dumped
                    if (line.Contains("using System;"))
                        continue;
                    if (line.Contains("public class"))
                        continue;
                    if (line=="{")
                        continue;
                    if (line=="}")
                        continue;
                        
                    // Change of format for "main"
                    if ((line.Contains(" Main(")) ||
                            (line.Contains(" Main (")))
                        line = "int main()";
                        
                    // Unindenting
                    if (line.StartsWith("    "))
                    {
                        line = line.Substring(4);
                    }
                    
                    // input / output
                    if (line.Contains("Console.Write("))
                    {
                        line = line.Replace("System.Console.Write(", "cout << ");
                        line = line.Replace("Console.Write(", "cout << ");
                        int posOfLastParenthesis = line.LastIndexOf(')');
                        if (posOfLastParenthesis > -1)
                            line = line.Remove(posOfLastParenthesis, 1);
                    }
                    
                    if (line.Contains("Console.WriteLine("))
                    {
                        line = line.Replace("System.Console.WriteLine(", "cout << ");
                        line = line.Replace("Console.WriteLine(", "cout << ");
                        int posOfLastParenthesis = line.LastIndexOf(')');
                        if (posOfLastParenthesis > -1)
                        {
                            line = line.Remove(posOfLastParenthesis, 1);
                            line = line.Insert(posOfLastParenthesis, " << endl");
                        }
                    }
                    
                    if (line.Contains("Console.ReadLine"))
                    {
                        line = line.Replace("System.", "");
                        line = line.Replace("Console.ReadLine(", "");
                        line = line.Replace("Convert.ToInt32(", "");
                        line = line.Replace(")", "");
                        line = line.Replace(" = ", "");
                        if (! line.Contains("int "))
                            line = "    cin >> " + line.Trim();
                        else
                        {
                            string[] parts = line.Trim().Split(' ');
                            line = line + " cin >> " + parts[1];
                        }
                    }

                    // Finally, changes are saved
                    outputFile.WriteLine(line);
                }

            } while(line != null);

            inputFile.Close();
            outputFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Entered path was too long");
            return;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/output error: {0}", ex.Message);
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
            return;
        }

    }
}
