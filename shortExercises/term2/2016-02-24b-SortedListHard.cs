using System;
using System.IO;
using System.Collections.Generic;


class MySortedList
{
    List<string> l;

    public MySortedList()
    {
        l = new List<string>();
    }

    public void Add(string s)
    {
        int actualLine = 0;
        if(l.Count==0)
            l.Add(s);
        else
        {
            while (actualLine < l.Count 
                && s.CompareTo(l[actualLine]) > 0)
            {
                actualLine++;
            }
            l.Insert(actualLine, s);
        }   
    }

    public string Get(int n)
    {
        return l[n];
    }

    public int Count()
    {
        return l.Count;
    }

    public void Remove(int n)
    {
        l.RemoveAt(n);
    }
}

class MySortedListTest
{
    static void Main(string[] args)
    {
        MySortedList myList = new MySortedList();
        string s="";
        do
        {
            Console.Write("Text? ");
            s = Console.ReadLine();
            if(s!="")
                myList.Add(s);
            Console.WriteLine("Amount of data: "+myList.Count());
            Console.WriteLine();
            
            for (int i = 0; i < myList.Count(); i++)
                Console.WriteLine(myList.Get(i));
        
        }while(s!="");
    }
}
