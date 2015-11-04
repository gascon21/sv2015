// Name: Jose Vicente Leal 
// Program:  monthdays

using System;
public class monthdays2
{
    public static void Main()
    {
        const int SIZE = 12;
        int position = -1;
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
                position = i;
            }  
        }    
        if (position != -1)
			Console.Write("Days: {0}",days[position]);
    } 
}
