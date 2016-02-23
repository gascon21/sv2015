// Chen Chao
// 22-02-2016

using System;
using System.IO;
using System.Collections;

public class Dictionary
{
    Hashtable dict = new Hashtable();
    
    public Dictionary()
    {
            
        StreamReader inFile = File.OpenText("UK-dict.txt");
        
        string line;
        
        do
        {
            line = inFile.ReadLine();
            
            if (line != null)
            {
                line = line.Trim();
                AddWord(line);
            }
        }
        while (line != null);
        inFile.Close();
    }
    
    public void AddWord(string newWord)
    {
        
       if (!dict.Contains(newWord[0])) 
       {
           dict.add(newWord[0], new ArrayList())
       }
       if (!IsInDict(newWord)) 
       {
           ArrayList arrayWords = ((ArrayList)dict[newWord[0]]);
           arrayWords.Add(newWord);
       }
    }
    
    public bool IsInDict(string newWord)
    {
        ArrayList arrayWords = (ArrayList)dict[newWord[0]];
        
        return arrayWords.Contains(newWord);
    }
}
