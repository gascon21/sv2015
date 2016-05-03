// Morse Challenge
// Miguel Moya Ortega

using System;

public class Morse
{
    public static void Main()
    {
        string[] words = {".-", "-...", "-.-.", "-..", ".", "..-.",
                "--.", "....", "..", ".----", "-.-", ".-..", "--", "-.",
                "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-",
                ".--", "-..-", "-.--", "--.."};
        string line;
        do
        {
            line = Console.ReadLine();
            if(line != "")
            {
                string toCompare = "";
                string sentence = line.ToUpper();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if(sentence[i] == 'O')
                        toCompare += '-';
                    else if(sentence[i] == 'A' || sentence[i] == 'E' ||
                    sentence[i] == 'I' || sentence[i] == 'U')
                        toCompare += '.';
                }
                if(toCompare == words[sentence[0] - 65])
                    Console.WriteLine(line + " OK");
                else
                    Console.WriteLine(line + " X");
            }
        }
        while (line != "");
    }
}
