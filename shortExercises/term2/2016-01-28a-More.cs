// "more" command

using System;
using System.IO;

public class More
{
    public static void Main(string[] args)
    {
        string fileName;

        if (args.Length == 1)
        {
            fileName = args[0];
        }
        else
        {
            Console.Write("Enter the name of the file: ");
            fileName = Console.ReadLine();
        }

        StreamReader textFile = File.OpenText(fileName);
        string line;
        int count = 0;

        do
        {
            line = textFile.ReadLine();

            if (line != null)
            {

                if (line.Length > 79)
                    Console.WriteLine(line.Substring(0, 79));
                else
                    Console.WriteLine(line);
                
                count++;
                if (count >= 24)
                {
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    count = 0;
                }
            }
        }
        while (line != null);

        textFile.Close();
    }
}
