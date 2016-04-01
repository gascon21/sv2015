// Gonzalo García Soler
// Challenge 55: Bike gears

using System;

public class BikeGears
{
    public static void Main()
    {
        bool finished = false;
        do
        {
            string inputCases = Console.ReadLine();
            string[] numbersString = inputCases.Split(' ');

            int nPlates = Convert.ToInt32(numbersString[0]);
            int nCrowns = Convert.ToInt32(numbersString[1]);

            if (nPlates != 0 && nCrowns != 0)
            {
                int[] plates = new int[nPlates];
                int[] crowns = new int[nCrowns];

                string inputPlates = Console.ReadLine();
                string[] tempPlates = inputPlates.Split(' ');

                string inputCrowns = Console.ReadLine();
                string[] tempCrowns = inputCrowns.Split(' ');

                for (int i = 0; i < nPlates; i++)
                    plates[i] = Convert.ToInt32(tempPlates[i]);

                for (int i = 0; i < nCrowns; i++)
                    crowns[i] = Convert.ToInt32(tempCrowns[i]);

                Array.Sort(crowns);
                Array.Reverse(crowns);

                int subtract = 0;
                int lastPlate = 0;
                int lastCrown = 0;
                int accountant = 0;

                string[] result = new string[nPlates * nCrowns];

                for (int i = 0; i < nPlates; i++)
                {
                    for (int j = 0; j < nCrowns; j++)
                    {
                        if (plates[i] - crowns[j] > subtract 
                            || plates[i] - crowns[j] == 0)
                        {
                            result[accountant] = (plates[i] + "-" + crowns[j]);
                            accountant++;
                        }
                        else if (plates[i] - crowns[j] == subtract 
                            && lastPlate < plates[i])
                        {
                            result[accountant - 1] = (plates[i] + "-" + crowns[j]);
                            result[accountant] = (lastPlate + "-" + lastCrown);
                            accountant++;
                        }
                        subtract = plates[i] - crowns[j];
                        lastPlate = plates[i];
                        lastCrown = crowns[j];
                    }
                }

                for (int i = 0; i < result.Length; i++)
                    Console.Write(result[i] + " ");

                Console.WriteLine();
            }
            else
                finished = true;       
        }
        while (!finished);
    }
}
