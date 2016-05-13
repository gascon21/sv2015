// Chen Chao
// 12-05-2016

using System;

public class TableroAjedrez
{
    public static void Main()
    {
        string text;
        string[] parts;
        
        do
        {
            text = Console.ReadLine();
            parts = text.Split();
            if (parts[0] != "0")
            {
                int n = Convert.ToInt32(parts[0]);
                char t = Convert.ToChar(parts[1]);
                
                string oddLine = "|";
                string evenLine = "|";
                for (int i = 0; i < 8; i++)
                {
                    if (i % 2 == 0)
                        oddLine += new string(' ', n) + new string(t, n);
                    else
                        evenLine += new string(t, n) + new string(' ', n);
                }
                oddLine += '|';
                evenLine += '|';
                
                string horSide = "|" + new string('-', 8 * n) + "|";
                Console.WriteLine(horSide);
                
                bool firstLine = false;
                
                for (int i = 0; i < n * 8; i++)
                {
                    if (i % n == 0)
                        firstLine = !firstLine;
                    if (firstLine)
                        Console.WriteLine(oddLine);
                    else
                        Console.WriteLine(evenLine);
                }
                
                Console.WriteLine(horSide);
            }
        }
        while (parts[0] != "0");
    }
}
