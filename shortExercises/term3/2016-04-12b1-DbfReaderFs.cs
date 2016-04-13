// Fields of a DBF file, using FileStream

using System;
using System.IO;

public class DbfFields
{
    
    public static int Main(string[] args)
    {
        string fileName;
        
        if (args.Length != 1)
        {
            Console.Write("Enter the name of the DBF file: ");
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
            FileStream input = File.OpenRead(fileName);
            
            const int HEADER_SIZE = 32;
            const int NAME_LENGTH = 11;
            byte [] data = new byte[HEADER_SIZE];
            
            // Read file header
            int amountRead=input.Read(data,0,HEADER_SIZE);

            if(amountRead!=HEADER_SIZE)
            {
                Console.WriteLine("Read Error");
                input.Close();
                return 2;
            }
            
            // Number of fields
            int headerBlocks = data[8]+data[9]*256;      
            int fields = headerBlocks / HEADER_SIZE - 1;

            // For each field, display the first 11 bytes, 
            // as ASCII characters
            for(int i =0;i<fields;i++)
            {
                input.Read(data,0,HEADER_SIZE);
                string fieldName = "";
                for (int j = 0; j < NAME_LENGTH; j++)
                    fieldName += Convert.ToChar( data[j] );
                Console.WriteLine("{0}: {1}",i+1, fieldName);
            }

            input.Close();
            
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            return 3;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/output error: {0}", ex.Message);
            return 4;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
            return 5;
        }
        return 0;
    }
}
