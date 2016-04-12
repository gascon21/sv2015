// Chen Chao, Vicente Cuenca
// 11-04-2016

using System;

public class Rubik
{
    public static void Main()
    {
        // Leer la imagen
        string line;
        do
        {
            line = Console.ReadLine();
            
            if (line != "0 0")
            {
                string[] size = line.Split(' ');
                int rows = Convert.ToInt32(size[0]) * 3;
                int cols = Convert.ToInt32(size[1]) * 3;
                string[] image = new string[rows];
                
                for (int i = 0; i < rows; i++)
                    image[i] = Console.ReadLine();
                
                // Leer cubos
                
                int cases = Convert.ToInt32(Console.ReadLine());
                const int SIDE = 3;
                for (int i = 0; i < cases; i++)
                {
                    string[] cube = new string[3];
                    for (int j = 0; j < cube.Length; j++)
                        cube[j] = Console.ReadLine();
                    
                    // Comprobar si el cubo introducido está en la imagen
                    // Saltando de 3 en 3, que es el tamaño de cada cubo
                    string result = "";
                    bool found = false;
                    int cubeX = 0;
                    int cubeY = 0;
                    
                    for (int j = 0; j < rows && !found; j += SIDE)
                    {
                        cubeX++;
                        for (int k = 0; k < cols; k += SIDE)
                        {
                            cubeY++;
                            if (image[j].Substring(k, SIDE) == cube[0] && 
                                    image[j+1].Substring(k, SIDE) == cube[1] &&
                                    image[j+2].Substring(k, SIDE) == cube[2])
                            {
                                result = "" + cubeX + " " + cubeY;
                                found = true;
                            }
                        }
                    }
                    
                    // Mostrar el resultado
                    if (found)
                        Console.WriteLine(result);
                    else
                        Console.WriteLine("NO SE USA");
                }
            }
        }
        while (line != "0 0");
    }
}
