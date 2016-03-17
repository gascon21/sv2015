// Carla Liarte Felipe
// 17-3-16
// https://code.google.com/codejam/contest/351101/dashboard#s=p1

using System;
using System.IO;
using System.Text;

public class ReverseWords
{
    static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            string sentence = Console.ReadLine();
            Console.Write("Case #{0}:", i + 1);
            string[] words = sentence.Split(' ');
            for (int j = words.Length - 1; j >= 0; j--)
            {
                Console.Write(" " + words[j]);
            }
            Console.WriteLine();
        }
    }
}
