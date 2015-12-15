// Count vowels and spaces

using System;
public class CountVowelsAndSpaces
{
    public static void CountVS(string text, ref int vowels, ref int spaces)
    {
        vowels=0;
        spaces=0;
        
        text = text.ToLower();
        
        for ( int i=0; i < text.Length; i++) 
        {
            if(text[i] == ' ')
                spaces++;
            if( (text[i] == 'a') || (text[i] == 'e') 
                    || (text[i] == 'i') || (text[i] == 'o' )
                    || (text[i] == 'u'))
                vowels++;
        }
    }
    

    public static void Main()
    {
        int amountOfVowels=10, amountOfSpaces=20;
        
        CountVS ("This is THE SENTENCE", 
            ref amountOfVowels, ref amountOfSpaces);
            
        Console.WriteLine("Vowels={0}, spaces={1}",
            amountOfVowels, amountOfSpaces);
    }
    
}
