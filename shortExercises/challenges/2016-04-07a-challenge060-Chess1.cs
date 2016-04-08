// Gonzalo García Soler
// Challenge 60: Chess

using System;

public class Chess
{
    public static void Main()
    {
        bool finished = false;
        long result = 0;

        do
        {
            string input = Console.ReadLine();

            if (input != "0 0 0")
            {
                string[] dataString = input.Split();
                
                long nWheat = Convert.ToInt64(dataString[0]);
                long multiplier = Convert.ToInt64(dataString[1]);
                long slots = Convert.ToInt64(dataString[2]);
                
                result = 0;
                for (int i = 0; i < slots; i++)
                {
                    result += nWheat;
                    nWheat *= multiplier;
                }
                Console.WriteLine(result);
            }
            else
                finished = true;                  
        }
        while (!finished);
    }
}
