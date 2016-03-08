/* Author: Victor Carretero Blasco

*/
using System;

public class Challenge20
{
    public static int ConverDateToNumber(string dateCompare)
    {
        string[] day = dateCompare.Split(' ');
        return Convert.ToInt32(day[0]) + 
            (Convert.ToInt32(day[1])*30) + 
            (Convert.ToInt32(day[2])*360);
    }
    
    public static void Main()
    {
        long cases = Convert.ToInt64(Console.ReadLine());
        int dayCompare = ConverDateToNumber(Console.ReadLine());
        
        for (long test = 0;test<cases;test++)
        {
            int dayNew = ConverDateToNumber(Console.ReadLine());
            if (dayCompare - dayNew < 30 )
                Console.WriteLine("NOCNF");
            else if (dayCompare - dayNew < 360 )
                Console.WriteLine("CNF");
            else
                Console.WriteLine("PRESIDENCIA");
        }
    }
}
