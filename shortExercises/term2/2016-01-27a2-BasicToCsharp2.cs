using System; 
using System.IO; 

public class BasicToCsharp2
{ 
    public static void Main() 
    { 
        string line, fileName;
        
        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();
        
        StreamReader inFile = File.OpenText(fileName);
        
        string outFileName = fileName;
        
        if (outFileName.EndsWith(".bas"))
        {
            outFileName = outFileName.Remove( outFileName.Length-4)
                + ".cs";
        }
        
        StreamWriter outFile = File.CreateText(outFileName);
        
        outFile.WriteLine("class BasicProgram");
        outFile.WriteLine("{");
        outFile.WriteLine("    public static void Main()");
        outFile.WriteLine("    {");
        do 
        { 
            line = inFile.ReadLine(); 
            
            if (line != null)
            {
                line = line.Trim(); 
                outFile.Write("        ");
                if (line.ToUpper().StartsWith("PRINT "))
                    outFile.WriteLine("System.Console.WriteLine(" 
                        +line.Substring(6) + ");");
                else if (line.ToUpper().StartsWith("INPUT "))
                    outFile.WriteLine("int " 
                        +line.Substring(6) 
                        + " = System.Convert.ToInt32( System.Console.ReadLine() );");
                else
                    outFile.WriteLine(line);
            }
        } 
        while (line != null);
        outFile.WriteLine("    }");
        outFile.WriteLine("}");
        
        inFile.Close();
        outFile.Close();
    } 
}
