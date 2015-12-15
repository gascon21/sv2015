/*
Create a program to ask the user for a symbol and answer if it is a 
(lowercase) vowel, a digit, or any other symbol, using "switch".
*/

using System;

public class SwitchVowel
{
    public static void Main()
    {
        Console.WriteLine("Enter a symbol: ");
        char c = Convert.ToChar(Console.ReadLine());
            
        switch (c)
        {
            case 'a': 
            case 'e':
            case 'i':
            case 'o':
            case 'u': 
                Console.WriteLine("Lowercase vowel"); 
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': 
                Console.WriteLine("Digit"); 
                break;
            default: 
                Console.WriteLine("Other symbol."); 
                break;
        }
    }
}
