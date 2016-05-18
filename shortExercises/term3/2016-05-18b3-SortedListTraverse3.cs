// SortedList traversal, version 3: .Keys
// Gonzalo García Soler

using System;
using System.Collections;

public class SortedListTraverse3
{
    public static void Main()
    {
        SortedList myDictionary = new SortedList();

        myDictionary.Add("hoyga", "oiga");
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("k", "que");
        myDictionary.Add("tk", "te quiero");
        myDictionary.Add("xq", "porque");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");

        foreach (string key in myDictionary.Keys)
        {
            Console.WriteLine(String.Format("{0}: {1}", 
                key, myDictionary[key]));
        }
    }
}
