// Strings manipulation

using System;
public class StringsManipulation
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();
        
        string text2 = text.ToUpper();
        Console.WriteLine(text2);
        
        string text3 = text.ToLower();
        Console.WriteLine(text3);
        
        string text4 = text.Remove(1,2);
        Console.WriteLine(text4);
        
        string text5 = text.Insert(2,"yo");
        Console.WriteLine(text5);
        
        string text6 = text.Replace(" ","_");
        Console.WriteLine(text6);
        
        string text7 = text.TrimStart();
        Console.WriteLine(text7);
        
        string text8 = text.TrimEnd();
        Console.WriteLine(text8);
        
        string text9 = text.Replace("a","A");
        Console.WriteLine(text9);
        
        string[] words = text.Split(' ');
        for(int i=0; i<words.Length; i++)
			Console.WriteLine(words[i]);
        
        
        
        
    } 
}
