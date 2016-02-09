// Binary Copier (bytes)

using System;
using System.IO;

public class BinaryCopier
{
    public static void Main()
    {
        Console.WriteLine("Enter the name of the file");
        string name = Console.ReadLine();
		if (File.Exists(name))
		{
			FileStream myRead = File.OpenRead(name);
			FileStream myWrite = File.Create(name + ".out");
			
			for (int i = 0; i < myRead.Length; i++)
			{
				myWrite.WriteByte( (byte)myRead.ReadByte() );
			}
			
			myRead.Close();
			myWrite.Close();
		}
    }
}
