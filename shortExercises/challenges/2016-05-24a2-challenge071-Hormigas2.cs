// Chao Chen y David Gascón

using System;
public class Hormigas
{
    public static void Main()
    {
        int bocatas;
        do
        {
            bocatas = Convert.ToInt32(Console.ReadLine());
            if(bocatas != 0)
            {
                string[] tapas = Console.ReadLine().Split();
                int pos = 0;
                int sum = 0;
                int max = 0;
                bool encontrado = false;
                for(int i = tapas.Length - 2 ; i >= 0 ; i --)
                {
                    sum += Convert.ToInt32(tapas[i + 1]);
                    if(tapas[i] == sum.ToString())
                    {
                        max = max > Convert.ToInt32(tapas[i]) ? max :
                                Convert.ToInt32(tapas[i]);
                        encontrado = true;
                        pos = i + 1;
                    }
                }
                if(encontrado)
                    Console.WriteLine("SI " + pos);
                else
                    Console.WriteLine("NO");
            }
        }while(bocatas != 0);
    }
}
