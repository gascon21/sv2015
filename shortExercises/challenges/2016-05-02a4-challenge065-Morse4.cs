// Morse Challenge
// Miguel Moya Ortega

using System;

public class Morse
{
    public static void Main()
    {
        string sentence;
        string[] words = {".-", "-...", "-.-.", "-..", ".", "..-.",
                "--.", "....", "..", ".----", "-.-", ".-..", "--", "-.",
                "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-",
                ".--", "-..-", "-.--", "--.."};
        do
        {
            sentence = Console.ReadLine();
            if(sentence != "")
            {
                string toCompare = "";
                sentence = sentence.ToUpper();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if(sentence[i] == 'O')
                        toCompare += '-';
                    else if(sentence[i] == 'A' || sentence[i] == 'E' ||
                    sentence[i] == 'I' || sentence[i] == 'U')
                        toCompare += '.';
                }
                if(toCompare == words[sentence[0] - 65])
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("X");
            }
        }
        while (sentence != "");
    }
}
