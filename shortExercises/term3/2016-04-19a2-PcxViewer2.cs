// Pcx Viewer for console
// Chen Chao
// 19-04-2016

using System;
using System.IO;
                
public class PcxViewer
{
    public static void Draw(byte n, short width, ref int count)
    {
        if (n >= 0 && n < 50)
            Console.Write('#');
        else if (n >= 50 && n < 100)
            Console.Write('=');
        else if (n >= 100 && n < 150)
            Console.Write('-');
        else if (n >= 150 && n < 200)
            Console.Write('.');
        else
            Console.Write(' ');
        count++;
        if (count % width == width - 1)
            Console.WriteLine();
    }

    public static int Main(string[] args)
    {
        // Check if file name entered
        string fileName;
        if (args.Length > 0)
            fileName = args[0];
        else
        {
            Console.WriteLine("Lost parameter, enter the file name");
            return 1;
        }                    

        // Check if file exists
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist");
            return 2;
        }
        
        try
        {
            // Read file
            BinaryReader reader = new BinaryReader(File.Open(fileName,
                FileMode.Open));
            int size = (int) reader.BaseStream.Length;
            byte[] data = new byte[size]; 
            reader.BaseStream.Read(data, 0, size);
            
            // Check if the file is a PCX file
            if (data[0] != 10)
            {
                Console.WriteLine("Not a PCX file");
                return 3;
            }

            // Check if the file is compressed           
            if (data[2] != 1)
            {
                Console.WriteLine("Image not compressed");
                return 4;
            }

            // Check if the file is a 8 bits PCX file
            if (data[3] != 8)
            {
                Console.WriteLine("Not a 8 bits image");
                return 5;
            }

            // Read the xMin, xMax, yMin and yMax of the image  
            reader.BaseStream.Seek(4, SeekOrigin.Begin);
            short xMin = reader.ReadInt16();
            short yMin = reader.ReadInt16();
            short xMax = reader.ReadInt16();
            short yMax = reader.ReadInt16();
            reader.Close();

            // Calculate width and height of the image
            short width = (short) (xMax - xMin + 1);
            short height = (short) (yMax - yMin + 1);
            byte bytesPerLine = data[66];
            bool repeat = false;
            int count = 0; 

            // Check if the width is equal to the byte 66
            if (bytesPerLine != width)
            {
                Console.WriteLine("The width and the bytes" +
                    " per line don't match");
                return 6;
            } 
            
            // Draw image            
            for (int i = 128; i < size; i++)
            {
                if (repeat)
                {
                    for (byte j = 0; j < data[i-1] - 192; j++)
                        Draw(data[i], width, ref count); 
                    repeat = false;
                }
                else if (data[i] <= 192)
                    Draw(data[i], width, ref count);
                else        
                    repeat = true;  
            }       
            return 0;
        }  
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/Output error: {0}", ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
        }
        return 7;
    }
} 
