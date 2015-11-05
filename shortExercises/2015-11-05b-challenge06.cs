/* challenge06: invert sentence

Input 
3
this is a test
foobar
all your base

Output 
Case #1: test a is this
Case #2: foobar
Case #3: base your all

*/

using System;

public class Challenge06
{
    public static void Main()    
    {
        int cases = Convert.ToInt32( Console.ReadLine() );
        
        for (int i=0; i< cases; i++)
        {
            string sentence = Console.ReadLine();
            Console.Write("Case #{0}:", i+1);
            string[] words = sentence.Split(' ');
            for(int j= words.Length-1; j>=0; j--)
            {
                Console.Write(" "+words[j]);
            }
            Console.WriteLine();
        }
    }
}
