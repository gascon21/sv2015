// Pcx Reader

using System;
using System.IO;

public class PcxReader
{
    public static int Main(string[] args)
    {
        BinaryReader myFile;
        string name;

        // Name must be a parameter
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: PcxReader filename.pcx");
            return 1;
        }

        // File must exist
        name = args[0];
        if (!File.Exists(name))
        {
            Console.WriteLine("File doesn't exit");
            return 2;
        }

        // Byte 0 must be 10
        myFile = new BinaryReader(File.Open(name, FileMode.Open));
        byte signature = myFile.ReadByte();

        if (signature != 10)
        {
            Console.WriteLine("Not a PCX file");
            return 3;
        }

        // Byte 1 = version (not used this time)
        myFile.ReadByte();

        // Byte 2 = compression (1=yes)
        if (myFile.ReadByte() == 1)
            Console.WriteLine("Compression: compressed");
        else
            Console.WriteLine("Compression: Not compressed");

        // Byte 3 = colour density
        if (myFile.ReadByte() == 8)
            Console.WriteLine("Colours: 256 colours");
        else
            Console.WriteLine("Colours: No 256 colours");

        // Image coordinates
        short xMin, yMin, xMax, yMax;
        xMin = myFile.ReadInt16();
        yMin = myFile.ReadInt16();
        xMax = myFile.ReadInt16();
        yMax = myFile.ReadInt16();
        int height = yMax - yMin + 1;
        int width = xMax - xMin + 1;

        // Bytes per line (must be equal to width, in 8 bits per pixel)
        myFile.BaseStream.Seek(66, SeekOrigin.Begin);
        int bpl = myFile.ReadByte();

        if (bpl == width)
            Console.WriteLine("Correct width: " + width);
        else
            Console.WriteLine("Widths don't match");

        // And finally, let's read bytes and decode
        myFile.BaseStream.Seek(128, SeekOrigin.Begin);
        int pos = 0;

        while (pos < width * height)
        {
            byte data = myFile.ReadByte();
            if (data < 192)
                ShowData(data, width, ref pos);
            else
            {
                int loop = data - 192; // !!!!!
                byte compressedData = myFile.ReadByte();
                for (int i = 0; i < loop; i++)
                {
                    ShowData(compressedData, width, ref pos);
                }
            }
        }
        myFile.Close();
        return 0;
    }


    // Auxiliary function to display a pixel in console
    public static void ShowData(byte data, int width, ref int pos)
    {
        if (data >= 200)
            Console.Write(' ');
        else if (data >= 150 && data <= 199)
            Console.Write('.');
        else if (data >= 100 && data <= 149)
            Console.Write('-');
        else if (data >= 50 && data <= 99)
            Console.Write('=');
        else if (data > 0)
            Console.Write('.');
        else
            Console.Write('#');

        if (pos % width == width - 1)
            Console.WriteLine();

        pos++;
    }
}
