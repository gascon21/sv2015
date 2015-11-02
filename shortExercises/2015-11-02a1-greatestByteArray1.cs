// Jose Vicente Leal Algarra
// Greatest value in an array of byte

using System;
public class GreatestByteArray
{
    public static void Main()
    {
        byte[] data = {7,20,15,17,32,5};
        byte max = 0; 

        for (int  i = 0;  i < 6 ; i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }  
        }    
        Console.Write("The biggest number is {0}",max);
    } 
}
