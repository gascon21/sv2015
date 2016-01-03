// Ruben Blanco
// Program: December 26th

// Create a program that asks the user for two words and the amount of 
// lines to display. Those words will be shown alternating, each in a 
// different line.

using System;

public class December26
{
    public static void WriteWords(string word1, string word2, short times)
    {
        for (int i = 1 ; i <= times; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(word2);

            else
                Console.WriteLine(word1);
        }
    }
    
    public static void Main()
    {
        Console.Write("Write a word: ");
        string word1 = Console.ReadLine();

        Console.Write("Write another word: ");
        string word2 = Console.ReadLine();

        Console.Write("Number of lines: ");
        short times = Convert.ToInt16(Console.ReadLine());

        WriteWords(word1, word2, times);
    }
}


