/* Chen Chao
 * A function that changes and specific char in a string.
 * */

using System;
using System.Text;

public class FunctionChangeChar3
{
    public static void ChangeChar(ref string text, int n, char c)
    {
        string textToModify = "";
        
        for (int i = 0; i < text.Length; i++)
        {
            if (i != n)
                textToModify += text[i];
            else
                textToModify += c;
        }
        
        text = textToModify;
    }
        public static void Main()
    {

        string sentence = "Tomato";

        ChangeChar(ref sentence, 5, 'a');
        Console.WriteLine(sentence);

    }
}
