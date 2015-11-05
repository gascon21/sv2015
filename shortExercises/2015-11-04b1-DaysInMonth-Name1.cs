// Name: Jose Vicente Leal 
// Program:  monthdays

using System;
public class monthdays
{
    public static void Main()
    {
        const int SIZE = 12;
        string[] names= {"january","february"," march","april",
            "may","june","july","august",
            "september","october","november","december"};
        ushort[] days = {31,28,31,30,31,30,31,31,30,31,30,31};
        
        Console.Write("Enter month:");
        string month = Console.ReadLine();
        
        for (int i = 0;  i < SIZE ; i++)
        {
            if (names[i] == month)
            {
                Console.Write("Days: {0}",days[i]);
            }  
        }    
    } 
}
