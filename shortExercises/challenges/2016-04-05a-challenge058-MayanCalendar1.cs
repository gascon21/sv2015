// Gonzalo García Soler
// Challenge 58: Mayan Calendar

/*
The Mayan civilisation used three different calendars. In their long 
count calendar there were 20 days (called kins) in a uinal, 18 uinals 
in a tun, 20 tuns in a katun and 20 katuns in a baktun. In our 
calendar, we specify a date by giving the day, then month, and finally 
the year. The Maya specified dates in reverse, giving the baktun 
(1-20), then katun (1-20), then tun (1-20), then uinal (1-18) and 
finally the kin (1-20).

The Mayan date 13 20 7 16 3 corresponds to the date 1 January 2000 
(which was a Saturday).

Write a program which, given a Mayan date (between 13 20 7 16 3 and 14 
1 15 12 3 inclusive), outputs the corresponding date in our calendar. 
You should output the month as a number.

Sample run

13 20 9 2 9
22 3 2001
*/

using System;

public class MayanCalendar
{
    public static int CalculateKins(int baktuns, int katuns, 
         int tuns, int uinals, int kins)
    {
        const int BAKTUN = 144000;
        const int KATUN = 7200;
        const int TUN = 360;
        const int UINAL = 18;

        return (kins + (uinals * UINAL) +
            (tuns * TUN) + (katuns * KATUN) + (baktuns * BAKTUN));
    }

    public static string ConvertKinsToDate(int kins)
    {       
        int year = (kins / 365) + 2000;
        int month = (kins % 365) / 30;

        int[] months = new int[] 
            { 31, (year % 4 == 0 ? 29 : 28),
            31, 30, 31, 30, 31, 31, 39, 31, 30, 31 };

        int divider = 1;
        
        if (month != 0)
        {
            int sum = 0;
            for (int i = 0; i < month - 1; i++)
                sum += months[i];

            divider = sum / (month - 1);
        }      
     
        int days = (kins % 365) % divider;

        return (month != 0 && days != 0) ? 
            days + " " + month + " " + year : "1 1 " + year;
    }

    public static void Main()
    {   
        bool finished = false;
        
        int startDate = CalculateKins(13,20,7,16,3);
        int finishDate = CalculateKins(14,1,15,12,3);
        
        do
        {
            string input = Console.ReadLine();
            
            if (input != "0")
            {
                string[] dataString = input.Split();

                int[] data = new int[dataString.Length];

                for (int i = 0; i < data.Length; i++)
                    data[i] = Convert.ToInt32(dataString[i]);

                int kins = CalculateKins(data[0], data[1], data[2], data[3], data[4]);
          
                Console.WriteLine(kins <= finishDate ? 
                    ConvertKinsToDate(kins - startDate) : "");
            }
            else
                finished = true;

        }
        while(!finished);
    }
}
