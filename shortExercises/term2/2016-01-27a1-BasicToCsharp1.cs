using System; 
using System.IO; 

public class BasicToCsharp1
{ 
    public static void Main() 
    { 
        string line, fileName;
        
        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();
        
        StreamReader inFile = File.OpenText(fileName);
        
        // Note: name should have ".bas" removed in a next version
        StreamWriter outFile = File.CreateText(fileName+".cs");
        
        outFile.WriteLine("class BasicProgram");
        outFile.WriteLine("{");
        outFile.WriteLine("    public static void Main()");
        outFile.WriteLine("    {");
        do 
        { 
            line = inFile.ReadLine(); 
            
            if (line != null)
            {
                outFile.Write("        ");
                if (line.ToUpper().StartsWith("PRINT "))
                    outFile.WriteLine("System.Console.WriteLine(" 
                        +line.Substring(6) + ");");
            }
        } 
        while (line != null);
        outFile.WriteLine("    }");
        outFile.WriteLine("}");
        
        inFile.Close();
        outFile.Close();
    } 
}
