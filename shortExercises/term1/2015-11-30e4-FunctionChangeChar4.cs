/* A function that changes and specific char in a string.
 * */

using System;
using System.Text;

public class FunctionChangeChar4
{

    public static void ChangeChar(ref string text,int n,char c)
    {
        text=text.Substring(0,n) + c  + text.Substring(n+1);
    }
    
    
    public static void Main()
    {

        string sentence = "Tomato";

        ChangeChar(ref sentence, 5, 'a');
        Console.WriteLine(sentence);

    }
}
