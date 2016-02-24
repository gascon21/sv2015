// PGM Viewer
// Version 2: BinaryReader

using System;
using System.IO;

public class PgmViewer 
{ 
    
    public static int Main(string[] args ) 
    {
        if (args.Length != 1)
        {
            Console.WriteLine("You must specify the name of the file as a parameter");
            Console.WriteLine("Example: pgmViewer.exe fileName.pgm");
            return 1;
        }

        string fileName = args[0];
        if (! File.Exists(fileName))
        {
            Console.WriteLine("File not found");
            return 2;
        }
        
        try
        {
            BinaryReader file = new BinaryReader(File.Open(fileName, FileMode.Open));
                        
            // Header 1: P5
            byte data;
            string format = "";
            for (int i=0; i<2; i++)
            {
                data = file.ReadByte();
                format += Convert.ToChar(data);
            }
            if (format != "P5")
            {
                Console.WriteLine("Not a P5 PGM file");
                return 3;
            }
           
            // Header 2: size
            file.ReadByte(); // NewLine
            string sizeAsString = "";
            do
            {
                data = file.ReadByte();
                if (data != 10)
                    sizeAsString += Convert.ToChar(data);
            }
            while (data != 10);
            
            string[] widthAndHeight = sizeAsString.Split(' ');
            int width = Convert.ToInt32(widthAndHeight[0]);
            int height = Convert.ToInt32(widthAndHeight[1]);
            Console.WriteLine("Size: {0} x {1}", width, height);
            
            // Header 3: Shades of grey -> Skipped
            file.BaseStream.Seek(4, SeekOrigin.Current);
            
            // And data
            for (int row = 0; row < height; row++)
            {
                for (int col=0; col < width; col++)
                {
                    data = file.ReadByte();
                    if (data>=200) 
                        Console.Write(" ");
                    else if (data>=150 && data<=199)
                        Console.Write(".");
                    else if (data>=100 && data<=149)
                        Console.Write("-");
                    else if (data>=50 && data<=99)
                        Console.Write("=");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
            file.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            return 4;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/output error: {0}", ex.Message);
            return 5;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
            return 6;
        }
        return 0;
    }
}
