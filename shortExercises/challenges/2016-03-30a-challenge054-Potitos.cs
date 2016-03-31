// Gonzalo García Soler
// Challenge 54: Potitos

using System;
using System.Collections;

public class Popitos
{
    public static bool AreWordsLowerCase(string[] words)
    {
        for (int i = 1; i < words.Length - 1; i++)
        {
            if (!words[i].Equals(words[i].ToLower()))
                return false;
        }
        return true;
    }

    public static bool IsSizeOfWordsCorrect(string[] words)
    {
        for (int i = 1; i < words.Length - 1; i++)
        {
            if (words[i].Length > 20)
                return false;
        }
        return true;
    }

    public static void Main()
    {
        bool finished = false;

        do
        {
            bool stop = false;

            ArrayList likedRecipe = new ArrayList();
            ArrayList dislikedRecipe = new ArrayList();
            ArrayList badIngredients = new ArrayList();

            int cases = Convert.ToInt32(Console.ReadLine());
            
            if(cases > 25)
                stop = true;

            if (cases != 0)
            {
                for (int i = 0; i < cases && !stop; i++)
                {
                    string sentence = Console.ReadLine();
                    string[] words = sentence.Split(' ');

                    if (words[0].Equals("SI:") 
                            && words[words.Length - 1].Equals("FIN") 
                            && words.Length <= 10
                            && IsSizeOfWordsCorrect(words)
                            && AreWordsLowerCase(words))
                    {
                        for (int accountant = 1; accountant < words.Length - 1; accountant++)
                            likedRecipe.Add(words[accountant]);
                    }
                    else if (words[0].Equals("NO:") 
                            && words[words.Length - 1].Equals("FIN") 
                            && words.Length <= 10
                            && IsSizeOfWordsCorrect(words)
                            && AreWordsLowerCase(words))
                    {
                        for (int accountant = 1; accountant < words.Length - 1; accountant++)
                            dislikedRecipe.Add(words[accountant]);
                    }
                    else
                        stop = true;
                }

                if (!stop)
                {
                    for (int i = 0; i < dislikedRecipe.Count; i++)
                    {
                        if ((!likedRecipe.Contains(dislikedRecipe[i]))
                                && (!badIngredients.Contains(dislikedRecipe[i])))
                            badIngredients.Add(dislikedRecipe[i]);    
                    }

                    badIngredients.Sort();

                    for (int i = 0; i < badIngredients.Count; i++)
                        Console.Write(badIngredients[i] + " ");

                    Console.WriteLine();
                }         
            }
            else
                finished = true; 
        }
        while (!finished);
    }
}
