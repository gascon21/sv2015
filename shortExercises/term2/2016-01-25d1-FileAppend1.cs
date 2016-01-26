/* Sergio Martínez Mira
 * Appending to a text file
 * */
 
using System;
using System.IO;

public class AppendSentences
{

    public static void Main()
    {
        string newline;
        
        StreamWriter myFile = File.AppendText("sentences.txt");
        do
        {
            Console.Write("Enter a sentence: ");
            newline = Console.ReadLine();
            if (newline != "")
                myFile.WriteLine(newline);
        }
        while(newline != "");
        
        myFile.Close();
    }
}
