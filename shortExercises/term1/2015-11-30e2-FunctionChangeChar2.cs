/* Sergio Martínez Mira
 * A function that changes and specific char in a string.
 * */

using System;
using System.Text;

public class FunctionChangeChar
{
    public static void ChangeChar(ref string text, int position, char charr)
    {
        StringBuilder mystring = new StringBuilder(text);
        mystring[position] = charr;
        text = mystring.ToString();

    }
    public static void Main()
    {

        string sentence = "Tomato";

        ChangeChar(ref sentence, 5, 'a');
        Console.WriteLine(sentence);

    }
}
