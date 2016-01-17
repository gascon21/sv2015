/*
 * Sacha Van de sijpe Bueno
 * Gonzalo Garcia Soler
*/

using System;

public class ChallengeGarden
{
    public static void Main()
    {
       int trys = Convert.ToInt32(Console.ReadLine());
       for (int i = 0; i < trys; i++)
       {
            string dimensions= Console.ReadLine();
           
            string [] data = dimensions.Split(' ');
            int width = Convert.ToInt32(data[0]);
            int heigth = Convert.ToInt32(data[1]);
            string[] rows = new string[heigth];
            bool valid = true;
            int found= 0;
            
            for (int j = 0; j < heigth; j++)
                rows[j] = Console.ReadLine();
            
            for (int j = 0; j < heigth; j++)
                for (int k = 0; k < width; k++)
                {
                    if (j == 0 && rows[j][k] == 'F' 
                            || j == heigth-1 && rows[j][k] == 'F' 
                            || rows[j][0] == 'F' 
                            || rows[j][width-1] == 'F')
                        valid = false;
                    else if (rows[j][k] == 'F')
                        if (rows[j-1][k] == 'F' 
                            || rows[j+1][k] == 'F' 
                            || rows[j][k-1] == 'F' 
                            || rows[j][k+1] == 'F')
                            valid = false;
                        else
                            found ++;
                }
            if (found == 0)
                valid = false;
                
            Console.WriteLine(valid ? "VALIDA" : "INVALIDA");
       }
    }
}
