/*
A function “WriteTriangleOfName” to display a triangle on screen from a 
certain sentence (extracting the rightmost characters) and with a 
certain maximum height. Each new row should be 1 character longer than 
the previous one, as seen in the following examples:

WriteTriangleOfName ("Nacho",3);
  o
  ho
 cho

WriteTriangleOfName ("Nacho",20);
    o
    ho
   cho
  acho
 Nacho
*/

using System;
public class Cadenas
{
    public static void WriteTriangleOfName(string name, int rows)
    {
        int max = rows;
        if (max > name.Length)
            max = name.Length;
        for (int i = 1 ; i <= max ; i++)
        {
            for (int spaces = 1; spaces <= max-i; spaces++)
            {
                Console.Write("_");
            }
            Console.WriteLine(name.Substring(name.Length-i));
        }
    }
    
    public static void Main()
    {
        WriteTriangleOfName ("Nacho",3);
        WriteTriangleOfName ("Nacho",20);
    } 
}
