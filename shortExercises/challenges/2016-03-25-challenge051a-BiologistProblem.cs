// Gonzalo García Soler

using System;

public class BiologistProblem
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] sequences = input.Split(' ');
   
        string result = "";

        int size = sequences[0].Length;

        for (int column = 0; column <= size; column++)
        {
            for (int position = 0; position <= size - column; position++)
            {
                string tempSequence = sequences[0].Substring(column, position);

                if (sequences[1].Contains(tempSequence) 
                        && tempSequence.Length > result.Length)
                    result = tempSequence;   
            }
        }
        Console.WriteLine(result);
    }
}
