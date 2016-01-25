// Name:  Jose Vicente , Victor Carretero
// Program:  challenger19

using System;
public class challenger
{
    public static void Main()
    {
        int numbercases = Convert.ToInt32(Console.ReadLine());
        byte[,] data = new byte[numbercases,2];
        
        for ( int i = 0 ; i < numbercases ; i++)
        {
            string line = Console.ReadLine();
            string[] str = line.Split(' ');
            data[i,0] = Convert.ToByte(str[0]);
            data[i,1] = Convert.ToByte(str[1]);
            
        }
        
        bool exit; 
        do
        {
            exit = true;

            for (int i = 1 ;  i < numbercases; i++)
            {
                if ( data[i-1,0]-  data[i,0] > 0 )
                {
                    byte temp = data[i-1,0];
                    data[i-1,0] = data[i,0];
                    data[i,0] = temp;
                    
                    byte temp2 = data[i-1,1];
                    data[i-1,1] = data[i,1];
                    data[i,1] = temp2;
                    
                    
                    exit = false;
                }
                else if ((data[i-1,0] ==  data[i,0]) && (data[i-1,1]-  data[i,1] > 0))
                {
                    byte temp = data[i-1,0];
                    data[i-1,0] = data[i,0];
                    data[i,0] = temp;
                    
                    byte temp2 = data[i-1,1];
                    data[i-1,1] = data[i,1];
                    data[i,1] = temp2;
                    
                    
                    exit = false;                    
                }
            }
        }
        while(exit == false);
        
        for ( int i = numbercases -1; i>= 0; i--)
            Console.WriteLine(data[i,0] + " " + data[i,1]);
        
    }
}
