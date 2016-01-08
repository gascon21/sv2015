/*
 * Sacha Van de sijpe Bueno
 */
using System;

public class challenge012
{
    public static void Main()
    {
        string text;
        
        do
        {
            text = Console.ReadLine();
            if (text != "")
            {
                bool equals = true;
                
                string[] words = text.Split(' ');
                for(int i=1; i<words.Length; i++)
                    if (words[i].Substring(0,2) != 
                            words[i-1].Substring(words[i-1].Length-2,2))
                        equals = false;
                        
                if (equals)
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");
            }
        }
        while (text != "");
    }
}
