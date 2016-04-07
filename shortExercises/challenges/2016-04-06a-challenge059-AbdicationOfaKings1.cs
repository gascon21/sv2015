// Gonzalo García Soler
// Challenge 59: Abdication of a king

using System;
using System.Collections;

public class AbdicationOfaKing
{
    public static int CalculateNumberSuccesor(
        string[] kings, string successor, ArrayList lastSuccessors)
    {
        int lastSuccessorCount = 0;
        for (int i = 0; i < lastSuccessors.Count; i++)
        {
            if (successor.Equals(lastSuccessors[i]))
                lastSuccessorCount++;
        }

        int count = 1;
        for (int i = 0; i < kings.Length; i++)
        {
            if (successor.Equals(kings[i]))
                count++;
        }
        return count + lastSuccessorCount;
    }

    public static void Main()
    {
        bool finished = false;

        do
        {
            int nKings = Convert.ToInt32(Console.ReadLine());

            if (nKings != 0)
            {
                string kingsInput = Console.ReadLine();
                int nSuccessors = Convert.ToInt32(Console.ReadLine());
                string successorsInput = Console.ReadLine();

                string[] kings = kingsInput.Split(' ');
                string[] successors = successorsInput.Split(' ');

                ArrayList lastSuccessors = new ArrayList();

                for (int i = 0; i < nSuccessors; i++)
                {                  
                    Console.WriteLine(CalculateNumberSuccesor(kings, successors[i], lastSuccessors));
                    lastSuccessors.Add(successors[i]);
                }
                Console.WriteLine();
            }
            else
                finished = true;
        }
        while (!finished);
    }
}
