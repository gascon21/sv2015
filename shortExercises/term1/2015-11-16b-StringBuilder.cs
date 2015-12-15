/*
* Carla Liarte Felipe
* Ask the user for a sentence and convert all of its spaces to 
* underscores, using "for" and a StringBuilder.
* (Note: you might need to look at topic 4.4.9 in you class book).
* 16-11-15
*/

using System;
using System.Text; 
public class StringBuilder1
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        StringBuilder sentence= new StringBuilder(Console.ReadLine());
            
        for(int i = 0; i < sentence.Length; i++ )
            if ( sentence[i] == ' ')
                sentence[i] = '_';
                
        Console.WriteLine("Final sentence: {0}", sentence);
    }
}
