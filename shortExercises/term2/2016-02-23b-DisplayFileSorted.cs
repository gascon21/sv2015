// Display file sorted

using System;
using System.IO;
using System.Collections.Generic;

public class DisplayFileSorted
{
    public static void Main(string[] args)
    {
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();

        if (!File.Exists(name))
        {
            Console.WriteLine("Not found!");
        }
        else
        {
            try
            {
                StreamReader file = new StreamReader(name);
                List<string> sentences = new List<string>();
                string line;
                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        sentences.Add(line);
                    }
                }
                while (line != null);
                file.Close();

                sentences.Sort();

                foreach(string sentence in sentences)
                    Console.WriteLine(sentence);
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
