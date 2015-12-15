// Jose Muñoz
// Change Char

using System;
public class Change
{
    public static void ChangeChar (ref string text, int position, char letter)
    {
        text = text.Remove(position, 1);
        text = text.Insert(position, letter.ToString());
    }
    
    public static void Main()
    {
        string sentence = "Tomato";
        ChangeChar(ref sentence, 5, 'a');
    }
}
