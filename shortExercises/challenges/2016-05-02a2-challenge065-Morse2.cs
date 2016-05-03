// Ruben Blanco
// Program: Morse Challenge

using System;
using System.Linq;

public class MorseChallenge
{
    public static void Main()
    {
        string text = ".";
        string word = "";
        string solution;
        string firstLetter = "";
        string[] letters = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                            "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "H", "Y", "Z" };
        string[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                          "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        while (text != "")
        {
            text = Console.ReadLine();
            word = text;
            text = text.ToUpper();
            solution = "";
            firstLetter = Convert.ToString(text[0]);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'O')
                    solution += "-";
                else if (text[i] == 'A' || text[i] == 'E' || text[i] == 'I' || text[i] == 'U')
                    solution += ".";
            }

            for (int j = 0; j < letters.Length; j++)
            {
                if(letters[j] == firstLetter)
                {
                    if (solution == morse[j])
                        Console.WriteLine(word + " OK");
                    else
                        Console.WriteLine(word + " X");
                }
            }
        }
    }
}
