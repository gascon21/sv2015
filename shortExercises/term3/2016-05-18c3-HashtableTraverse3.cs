// Hashtable traversal, version 3: DictionaryEntry
// Chen Chao

using System;
using System.Collections;

public class HashtableTraverse3
{
    public static void Main()
    {
        Hashtable myDictionary = new Hashtable();
        
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
