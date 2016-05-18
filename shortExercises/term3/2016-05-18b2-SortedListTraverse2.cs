// SortedList traversal, version 2: Enumerator
// Jose Muñoz

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

        IDictionaryEnumerator myEnumerator = myDictionary.GetEnumerator();
        while (myEnumerator.MoveNext())
            Console.WriteLine("{0} = {1}", myEnumerator.Key, myEnumerator.Value);
    }
}
