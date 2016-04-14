// File Inverter using BinaryReader and BinaryWriter
// Version 2: seeking from the current position
 
using System;
using System.IO;

class FileInverter
{
    public static void Main()
    {
        Console.Write("File name?");
        string fileName = Console.ReadLine();
        if(!File.Exists(fileName))
            Console.WriteLine("File not found");
        else
        {
            try
            {
                BinaryReader br = new BinaryReader(File.Open
                    (fileName, FileMode.Open));
                BinaryWriter bw = new BinaryWriter(File.Open
                    (fileName+".inv", FileMode.Create));
                    
                br.BaseStream.Seek(-1, SeekOrigin.End);
                
                for(long i=br.BaseStream.Length; i>1; i--)
                {
                    bw.Write(br.ReadByte());
                    br.BaseStream.Seek(-2, SeekOrigin.Current);
                }
                br.Close();
                bw.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/output error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: {0}", ex.Message);
            }
        }
    }
}
