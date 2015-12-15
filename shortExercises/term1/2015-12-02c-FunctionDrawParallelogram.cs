/*Create a function which draws a parallelogram, with the width,
 height and character specified as parameters (2 points):

DrawParallelogram(10,4,'*');
**********
 **********
  **********
   **********
   José Miguel Leonis */
using System;
public class ej104
{
    public static void DrawParallelogram (int width, int height, char userchar)
    {
        int spaces =0;
        for(int i =0; i<height;i++)
        {
            for (int space=0; space < spaces; space++)
                Console.Write(" ");
            for(int col=0; col < width; col++)
                Console.Write(userchar);
            spaces++;
            Console.WriteLine();
        }
    }
    public static void Main()
    {
        DrawParallelogram(10,4,'*');
    }
}
