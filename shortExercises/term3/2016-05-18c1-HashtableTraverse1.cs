// Hashtable traversal, version 1: Enumerator
// Jose Muñoz

using System;
using System.Collections;

public class HashtableTraverse1
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

        IDictionaryEnumerator myEnumerator = myDictionary.GetEnumerator();
        while (myEnumerator.MoveNext())
            Console.WriteLine("{0} = {1}", myEnumerator.Key, myEnumerator.Value);
    }
}
