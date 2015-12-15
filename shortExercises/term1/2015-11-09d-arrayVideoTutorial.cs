// Pedro Antonio Pérez Paterna
// Program writed about the video of C# arrays.
using System;
public class videoArray
{
    public static void Main()
    {
        int[] ages={25,27,23,34,36};
        int totalAge=0;
        
        for(int i=0;i<ages.Length;i++)
        {
            Console.WriteLine("Age:{0}",ages[i]);
            totalAge+=ages[i];
        }
        Console.WriteLine("The sum of the ages is: {0}",totalAge);
    }
}
