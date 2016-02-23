// David Gascón López
// Hoygan to Spanish

// Create a C# program to translate from Hoygan (a sentence entered by 
// the user) to Spanish, using a SortedList. It must work correctly with 
// the following sentence:
// hoygan porfabor nesecito alluda Pasa k no se xq tk

using System;
using System.IO;
using System.Collections;

public class CaniConverter
{
    public static void Main()
    {
        SortedList myCaniDiccio = new SortedList();
        
        myCaniDiccio.Add("hoyga", "oiga");
        myCaniDiccio.Add("hoygan", "oigan");
        myCaniDiccio.Add("k", "que");
        myCaniDiccio.Add("tk", "te quiero");
        myCaniDiccio.Add("xq", "porque");
        myCaniDiccio.Add("porfabor", "por favor");
        myCaniDiccio.Add("nesecito", "necesito");
        myCaniDiccio.Add("alluda", "ayuda");

        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Trim().Split(' ');
        string translation = "";
        
        for(int i = 0 ; i < words.Length ; i ++)
        {
            if(myCaniDiccio.Contains(words[i]))
                translation += (string) myCaniDiccio[words[i]] + " ";
            else
                translation += words[i] + " ";
        }
        Console.WriteLine(translation.TrimEnd());
    }
}
