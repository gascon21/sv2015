// Mix and sort files

using System;
using System.IO;
using System.Collections;

public class MixAndSort
{
    public static void Main(string[] args)
    {
        string fileName1, fileName2;
        
        if (args.Length < 2)
        {
            Console.Write("First file to merge and sort? ");
            fileName1 = Console.ReadLine();

            Console.Write("Second file to merge and sort? ");
            fileName2 = Console.ReadLine();
        }
        else
        {
            fileName1 = args[0];
            fileName2 = args[1];
        }

        if (!File.Exists(fileName1) || !File.Exists(fileName2))
        {
            Console.WriteLine("One of the files doesn't exist");
        }
        else
        {
            try
            {
                StreamReader file1 = File.OpenText(fileName1);
                StreamReader file2 = File.OpenText(fileName2);
                ArrayList sentences = new ArrayList();
                string line;

                do
                {
                    line = file1.ReadLine();
                    if (line != null) sentences.Add(line);
                }
                while (line != null);
                file1.Close();

                do
                {
                    line = file2.ReadLine();
                    if (line != null) sentences.Add(line);
                }
                while (line != null);
                file2.Close();

                sentences.Sort();

                foreach(string word in sentences)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
