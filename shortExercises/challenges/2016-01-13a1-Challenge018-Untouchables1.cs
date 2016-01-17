// Chen Chao y Sergio Martínez
// 13-01-2016

using System;

public class Untouchble
{
    public static void Main()
    {
        int times = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < times; i++)
        {
            string text = Console.ReadLine();
            string[] text2 = text.Split(' ');
            bool invalid = false;
            bool fFound = false;
            
            int row = Convert.ToInt32(text2[1]);
            int col = Convert.ToInt32(text2[0]);
            string[] map = new string[row];
            
            for (int j = 0; j < row; j++)
                map[j] = Console.ReadLine();
                
            for (int j = 0; j < row; j++)
            {
                for (int k = 0; k < col; k++)
                {
                    if (map[0].Contains("F") || map[row-1].Contains("F") || 
                            map[j][0] == 'F' || map[j][col-1] == 'F' || 
                            (map[j][k] == 'F' && map[j][k-1] == 'F') ||
                            (map[j][k] == 'F' && map[j][k+1] == 'F') ||
                            (map[j][k] == 'F' && map[j-1][k] == 'F') ||
                            (map[j][k] == 'F' && map[j+1][k] == 'F') ||
                            (map[j][k] == 'F' && map[j-1][k-1] == 'F') ||
                            (map[j][k] == 'F' && map[j-1][k+1] == 'F') ||
                            (map[j][k] == 'F' && map[j+1][k-1] == 'F') ||
                            (map[j][k] == 'F' && map[j+1][k-1] == 'F'))
                        invalid = true;
                    if (map[j][k] == 'F')
                        fFound = true;
                }
            }
            if (fFound)
            {
                if (invalid)
                        Console.WriteLine("INVALIDA");
                else
                    Console.WriteLine("VALIDA");
            }
            else
                Console.WriteLine("INVALIDA");
        }
    }
}
