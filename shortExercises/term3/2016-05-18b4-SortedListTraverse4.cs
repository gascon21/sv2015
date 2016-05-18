// SortedList traversal, version 4: DictionaryEntry
// Chen Chao

using System;
using System.Collections;

public class SortedListTraverse2
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
        
        foreach (DictionaryEntry key in myDictionary)
            Console.WriteLine(key.Key + " = " + key.Value);
    }
}
