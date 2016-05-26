// Chen Chao
// 18-05-2016

using System;

public class Paint
{
    public static void PaintIt(string[] image, int x, int y, char letter,
            char charToChange)
    {
        int ancho = image[0].Length;
        int alto = image.Length;
        
        if (image[y][x] == charToChange)
            image[y] = image[y].Remove(x, 1).Insert(x, "" + letter);
        
        if (y - 1 >= 0 && image[y - 1][x] == charToChange)
            PaintIt(image, x, y - 1, letter, charToChange);
            
        if (x + 1 < ancho && image[y][x + 1] == charToChange)
            PaintIt(image, x + 1, y, letter, charToChange);
            
        if (y + 1 < alto && image[y + 1][x] == charToChange)
            PaintIt(image, x, y + 1, letter, charToChange);
            
        if (x - 1 >= 0 && image[y][x - 1] == charToChange)
            PaintIt(image, x - 1, y, letter, charToChange);
            
        if (y - 1 >= 0 && x - 1 >= 0 && 
                image[y - 1][x - 1] == charToChange)
            PaintIt(image, x - 1, y - 1, letter, charToChange);
            
        if (y + 1 < alto && x - 1 >= 0 && 
                image[y + 1][x - 1] == charToChange)
            PaintIt(image, x - 1, y + 1, letter, charToChange);
            
        if (y - 1 >= 0 && x + 1 < ancho && 
                image[y - 1][x + 1] == charToChange)
            PaintIt(image, x + 1, y - 1, letter, charToChange);
            
        if (y + 1 < alto && x + 1 < ancho && 
                image[y + 1][x + 1] == charToChange)
            PaintIt(image, x + 1, y + 1, letter, charToChange);
    }
    
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < cases; i++)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] lines = new string[size];
            for (int j = 0; j < lines.Length; j++)
                lines[j] = Console.ReadLine();
            
            int tries = Convert.ToInt32(Console.ReadLine());
            
            for (int j = 0; j < tries; j++)
            {
                string[] text = Console.ReadLine().Split();
                int x = Convert.ToInt32(text[0]) - 1;
                int y = Convert.ToInt32(text[1]) - 1;
                char letter = Convert.ToChar(text[2]);
                char charToChange = lines[y][x];
                PaintIt(lines, x, y, letter, charToChange);
            }
            
            for (int j = 0; j < size; j++)
                Console.WriteLine(lines[j]);
        }
    }
}
