/*

Create a program to display a black and white image 
in 256 color BMP format in the console, such as the example 
file named "welcome8.bmp".

(First approach: image is drawn upside down)

*/

using System; 
using System.IO;

public class DisplayBMP
{
    public static void Main ()
    {
        byte width, height;
        
        Console.Write("Enter the name of the BMP file: ");
        string nameFile = Console.ReadLine();
    
        if (File.Exists(nameFile))
        {
            try
            {
                FileStream file = new FileStream(nameFile, FileMode.Open);
                
                // Let's read witdh and height
                // (only first byte, assuming they are <=255)
                file.Seek(18, SeekOrigin.Begin);
                width = (byte) file.ReadByte();                

                file.Seek(22, SeekOrigin.Begin);
                height = (byte) file.ReadByte();

                // And let's read the image data (after the header)
                int size = width*height;
                byte[] data = new byte[size];
                
                file.Seek(-size, SeekOrigin.End);
                file.Read(data, 0, size);
                file.Close();
            
                int pos = 0;
                for (int row=0; row<height; row++)
                {
                    for (int col=0; col<width; col++)
                    {
                        if (data[pos] > 127)
                            Console.Write('.');
                        else
                            Console.Write('*');
                        pos++;
                    }
                    Console.WriteLine ();
                }                    
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Entered path was too long");
                return;
            }
            catch (IOException exp)
            {
                Console.WriteLine("Input/output error: {0}", exp.Message);
                return;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Unexpected error: {0}", exp.Message);
                return;
            }
        }
    }
}
