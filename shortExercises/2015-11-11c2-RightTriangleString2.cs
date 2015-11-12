/* 
Create a program that asks the user for a string and displays a 
right-aligned triangle:

____o
___ho
__cho
_acho
Nacho

*/
using System;
public class Cadenas
{
    public static void Main()
    {
        string name;
        int spaces, posWord, letters;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        letters = 1;
        posWord = name.Length-1;
        spaces = name.Length-1;
        
        for (int i = 0 ; i < name.Length ; i++)
        {
            Console.Write( new String('_', spaces) );
            Console.WriteLine(name.Substring(posWord, letters));
            spaces --;
            letters ++;
            posWord --;
            
        }
    } 
}
