// SortedList traversal, version 1: GetKey(n)
// Victor Carretero

using System;
using System.Collections;

public class SortedListTraverse1
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

        for (int i = 0; i < myDictionary.Count; i++)
        {
            string key = (string) myDictionary.GetKey(i);
            Console.WriteLine(key + " = " + myDictionary[key]);
        }
    }
}
