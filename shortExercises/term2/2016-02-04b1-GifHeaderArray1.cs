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
        
        byte [] myArray = new byte [5];
        
        if (! File.Exists(name))
        {
            Console.WriteLine("File does not exist");
        }
        else
        {
            FileStream myFile = File.OpenRead(name);
            
            int position = 0;
            int amountToRead = 5;
            myFile.Read(myArray, position,amountToRead);
            
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
        myFile.Close();
        }
    }
}
