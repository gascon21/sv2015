// Pedro Antonio Pérez Paterna

/*
Create a program that asks the user for a string and creates three new 
strings from it:

- First string must contain the initials (first letter and those after 
  a space, uppercase)

- Second string must have odd letters uppercase and even letter 
  lowercase

- Third string must replace all lowercase A by uppercase A, except if 
  they are preceded with a space

For example, if the string is "ProGramming class a1 A2", the resulting 
strings should be:

PCA
PrOgRaMmInG ClAsS A1 a2
ProGrAmming clAss a1 A2
*/

using System;
public class stringManipulation2
{
    public static void Main()
    {
        Console.Write("Enter sentence: ");
        string sentence = Console.ReadLine();
        
        string[] words = sentence.Split(' ');
        string sentence2="";
        for(int i=0; i<words.Length; i++)
            sentence2+=words[i][0];
        sentence2=sentence2.ToUpper();
        Console.WriteLine(sentence2);
        
        string sentence3 = "";
        for (int i = 0; i <sentence.Length; i++)
            if (i % 2 == 0)
                sentence3 += Convert.ToString(sentence[i]).ToUpper();
            else
                sentence3 += Convert.ToString(sentence[i]).ToLower();
        Console.WriteLine(sentence3);

        /* Note that the following approach is not correct:
           letters "a" with a leading space should not be changed 
        string sentence4 = "";
        sentence4 = sentence.Replace("a","A");
        sentence4 = sentence4.Replace(" A"," a");
            Console.WriteLine(sentence4);
        */
        
        string sentence4 = sentence.Substring(0,1);
        for (int i = 1; i <sentence.Length; i++)
            if ((sentence[i] == 'a') &&  (sentence[i-1] != ' '))
                sentence4 += 'A';
            else
                sentence4 += sentence[i];
        Console.WriteLine(sentence4);
    }
}
