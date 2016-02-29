// Search in a text file, using a List as intermediate storage
// Sacha Van de sijpe Bueno

using System;
using System.Collections.Generic;
using System.IO;

public class MultipleSearch
{
    public static void Main()
    {
        Console.Write("Enter the name of file: ");
        string fileName = Console.ReadLine();

        // Read file
        if (File.Exists(fileName))
        {
            List<string> myList = new List<string>();
            StreamReader myFileIn = File.OpenText(fileName);

            string line;

            do
            {
                line = myFileIn.ReadLine();
                if (line != null)
                {
                    myList.Add(line);
                }
            } while (line != null);
            myFileIn.Close();

            
            // Search in list
            bool found = false;

            do
            {
                found = false;
                Console.Write("Enter word or sentence to search: ");
                line = Console.ReadLine();
                if (line != "")
                    for (int i = 0; i < myList.Count; i++)
                        if (myList[i].Contains(line))
                        {
                            Console.WriteLine(myList[i]);
                            found = true;
                        }
                if (!found)
                    Console.WriteLine("Nothing found");

            } while (line != "");
        }
    }
}
