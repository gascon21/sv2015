// Chen Chao
// 17-05-2016

using System;

public class SopaDeLetras
{
    public static void Main()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[size];
        for (int i = 0; i < size; i++)
            words[i] = Console.ReadLine();
        
        int numWords = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < numWords; i++)
        {
            bool found = false;
            string word = Console.ReadLine();
            
            for (int j = 0; j < size && !found; j++)
                if (words[j].Contains(word))
                    found = true;
            
            for (int j = 0; j < words[0].Length && !found; j++)
            {
                string tempWord = "";
                for (int k = 0; k < size ; k++)
                    tempWord += words[k][j];
                
                if (tempWord.Contains(word))
                    found = true;
            }
            
            if (found)
                Console.WriteLine("SI");
            else
                Console.WriteLine("NO");
        }
    }
}
