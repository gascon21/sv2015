// TextCensorer (reading one line at a time)
// Miguel Moya Ortega

using System;
using System.IO;

public class Censored
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        
        if(!File.Exists(fileName))
            Console.WriteLine("File don't found!");
        else
        {
            try
            {
                StreamReader file = File.OpenText(fileName);
                StreamReader file1 = File.OpenText("CENSORED.TXT");
                StreamWriter file2 = File.CreateText(fileName + ".censored");
                
                // Create the list of censored words
                int words = Convert.ToInt32(file1.ReadLine());
                string[] censored = new string[words];
                for (int i = 0; i < words; i++)
                {
                    censored[i] = file1.ReadLine();
                }
                
                // And process each line of the source file
                string line;
                do
                {
                    line = file.ReadLine();
                    if(line != null)
                    {
                        for (int i = 0; i < words; i++)
                        {
                            line = line.Replace(" " + censored + "  ",
                                    " [CENSORED] ");
                            line = line.Replace(" " + censored + ". ",
                                    " [CENSORED]. ");
                            line = line.Replace(" " + censored + ", ",
                                    " [CENSORED], ");
                        }
                        file2.WriteLine(line);
                    }
                }
                while (line != null);
                
                file2.Close();
                file1.Close();
                file.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/Output error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
