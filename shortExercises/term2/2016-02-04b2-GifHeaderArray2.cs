// Ruben Blanco
// Program: GIFbinaryFiles

using System;
using System.IO;

public class GIFbinaryFiles
{
    public static void Main()
    {
        Console.Write("Enter the name of the file: ");
        string name = Console.ReadLine();
        
        if (! File.Exists(name))
        {
            Console.WriteLine("File does not exist");
        }
        else
        {
            FileStream myFile = File.OpenRead(name);
            byte [] myArray = new byte [myFile.Length];
            
            int position = 0;
            int amountToRead = (int) myFile.Length;
            int amountRead;
            
            amountRead = myFile.Read(myArray, 
                position,amountToRead);
            myFile.Close();
                
            if (amountRead != amountToRead)
            {
                Console.WriteLine("Read Error");
                return;
            }
            
            if((myArray[0] == 'G')&&(myArray[1]=='I')
                    &&(myArray[2]=='F')&&(myArray[3]=='8'))
            {
                if(myArray[4] == '7')
                    Console.WriteLine("It´s a GIF v87");
                
                else if(myArray[4] == '9')
                    Console.WriteLine("It´s a GIF v89");
                
                else
                    Console.WriteLine("Not a valid GIF");
            }
            else
                Console.WriteLine("Not a GIF file");
        
        }
    }
}
