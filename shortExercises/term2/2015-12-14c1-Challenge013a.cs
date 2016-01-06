// Chen Chao
// 14-12-2015

using System;

public class Challenge013
{
    public static uint TurnedOn(char n)
    {
        byte segments;
        uint timesOn = 0;
        
        switch(n)
        {
            case '0':
                segments = 6;
                timesOn += segments;
                break;
            case '1':
                segments = 2;
                timesOn += segments;
                break;
            case '2':
                segments = 5;
                timesOn += segments;
                break;
            case '3':
                segments = 5;
                timesOn += segments;
                break;
            case '4':
                segments = 4;
                timesOn += segments;
                break;
            case '5':
                segments = 5;
                timesOn += segments;
                break;
            case '6':
                segments = 6;
                timesOn += segments;
                break;
            case '7':
                segments = 3;
                timesOn += segments;
                break;
            case '8':
                segments = 7;
                timesOn += segments;
                break;
            case '9':
                segments = 6;
                timesOn += segments;
                break;
        }
        
        return timesOn;
    }
    
    public static void Main()
    {
        uint seconds = Convert.ToUInt32(Console.ReadLine());
        uint timesOn = 0;
        string time;
        
        if (seconds < 60)
        {
            for (int s = 0; s <= seconds; s++)
            {
                time = s.ToString("000000");
                
                for (int j = 0; j < time.Length; j++)
                    timesOn += TurnedOn(time[j]);
            }
        }
        
        else
        {
            byte hours = 0;
            byte minutes = 0;
            
            while (seconds >= 3600)
            {
                hours++;
                seconds -= 3600;
            }
            
            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
            
            if (hours > 0)
            {
                for (int h = 0; h < hours; h++)
                    for (int m = 0; m < 60; m++)
                        for (int s = 0; s < 60; s++)
                        {
                            time = (h.ToString("00") + m.ToString("00") +
                                s.ToString("00"));
                            
                            for (int i = 0; i < time.Length; i++)
                                timesOn += TurnedOn(time[i]);
                        }
                time = (hours.ToString("00") + "0000");
                for (int i = 0; i < time.Length; i++)
                    timesOn += TurnedOn(time[i]);
            }
            
            if (minutes > 0)
            {
                for (int m = 0; m < minutes; m++)
                    for (int s = 0; s < 60; s++)
                    {
                        time = (hours.ToString("00") + m.ToString("00") +
                            s.ToString("00"));
                        
                        for (int i = 0; i < time.Length; i++)
                            timesOn += TurnedOn(time[i]);
                    }
                time = ("00" + minutes.ToString("00") + "00");
                for (int i = 0; i < time.Length; i++)
                    timesOn += TurnedOn(time[i]);
            }
            
            if (seconds > 0)
                for (int s = 1; s <= seconds; s++)
                {
                    time = (hours.ToString("00") + 
                        minutes.ToString("00") + s.ToString("00"));
                    
                    for (int i = 0; i < time.Length; i++)
                        timesOn += TurnedOn(time[i]);
                }
        }
        Console.WriteLine(timesOn);
    }
}
