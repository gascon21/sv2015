// Indra Lopez Galvez
// Program to dump the contain of one file on another file

using System;
using System.IO;

public class BatCompiler{
    public static void Main (string [] args) {
        string name;
        string line;
        if(args.Length ==0) {
            Console.Write("Enter the name of the file please: ");
            name = Console.ReadLine();
        }
        else {
            name = args[0];
        }
        if(!File.Exists (name)) {
            Console.WriteLine("Error with your file, enter a valid name");
        }
        else {
            StreamReader inFile = File.OpenText(name);
            StreamWriter newFile = File.CreateText(name+".cs");
            newFile.WriteLine("using System;");
            newFile.WriteLine("using System.IO;");
            newFile.WriteLine("using System.Diagnostics;");
            newFile.WriteLine("public class FicheroBat");
            newFile.WriteLine("{");
            newFile.WriteLine("    public static void Main(string[] args)");
            newFile.WriteLine("    {");
            newFile.WriteLine("        Process proc;");
            
            do {
                line = inFile.ReadLine();
                if(line !=null) {
                    if(line.ToUpper().Trim() == "CLS") {
                        newFile.WriteLine("        Console.Clear();");
                    }
                    
                    else if(line.Trim().ToUpper().StartsWith("ECHO ")) {
                        string text = line.Trim().Substring(5).TrimStart();
                        newFile.WriteLine("        Console.WriteLine(\""
                            +text+"\");");
                    }
                    
                     else if(line.Trim().ToUpper().StartsWith("CD ")) {
                        string text = line.Trim().Substring(3);
                        newFile.WriteLine("        Directory.SetCurrentDirectory(\""
                            +text+"\");");
                    }
                    else {
                        newFile.WriteLine("        proc = Process.Start(\"" 
                            + line + "\"); proc.WaitForExit();");
                    }
                    
                }
            } while(line !=null);
            newFile.WriteLine("    }");
            newFile.WriteLine("}");
            
            inFile.Close();
            newFile.Close();
        }
    }
}
