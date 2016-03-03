//Jose Vicente y Victor Carretero

/*
Se nos mostrará los soldaditos ordenados de mayor a menor, en base a su 
altura, anchura y peso, en ese orden de importancia. En caso de empate 
total, se ordenarán de menor a mayor número de identificación.

Ejemplo de entrada
7
1 100 100 100
2 80 100 10
3 80 10 90
4 80 10 40
5 80 44 33
9 80 44 33
6 1000 1 1

Ejemplo de salida
6 1000 1 1
1 100 100 100
2 80 100 10
5 80 44 33
9 80 44 33
3 80 10 90
4 80 10 40
*/

using System;

public class ChallengerB
{
    public static void Main()
    {
        
        int  size = Convert.ToInt32(Console.ReadLine());
        
        int[,] data = new int[size,4];
        
        for ( int i = 0 ; i < size; i++)
        {   
            string line = Console.ReadLine();
            string[] values = line.Split(' ');
                data[i,0] = Convert.ToInt32(values[0]);
                data[i,1] = Convert.ToInt32(values[1]);
                data[i,2] = Convert.ToInt32(values[2]);
                data[i,3] = Convert.ToInt32(values[3]);
        }
        
        
        bool exit;
        do
        {
            exit = true;

            for (int i = 1 ;  i < size; i++)
            {
                if ( data[i,1] >  data[i-1,1] )
                {
                    int temp = data[i-1,1];
                    data[i-1,1] = data[i,1];
                    data[i,1] = temp;
 
                    temp = data[i-1,2];
                    data[i-1,2] = data[i,2];
                    data[i,2] = temp;
                                                   
                    temp = data[i-1,3];
                    data[i-1,3] = data[i,3];
                    data[i,3] = temp; 
                    
                    temp = data[i-1,0];
                    data[i-1,0] = data[i,0];
                    data[i,0] = temp;                       
                    
                                          
                    exit = false;
                }
            }
        }
        while(exit == false);


        do
        {
            exit = true;

            for (int j = 1 ;  j < size; j++)
            {
                if (( data[j,2] >  data[j-1,2]) 
                    && (data[j,1] ==  data[j-1,1] ))
                {
                    int temp = data[j-1,1];
                    data[j-1,1] = data[j,1];
                    data[j,1] = temp;
 
                    temp = data[j-1,2];
                    data[j-1,2] = data[j,2];
                    data[j,2] = temp;
                                                   
                    temp = data[j-1,3];
                    data[j-1,3] = data[j,3];
                    data[j,3] = temp; 
                    
                    temp = data[j-1,0];
                    data[j-1,0] = data[j,0];
                    data[j,0] = temp;                         
                    
                                          
                    exit = false;
                }
            }
        }
        while(exit == false);

        do
        {
            exit = true;

            for (int j = 1 ;  j < size; j++)
            {
                if (( data[j,0] <  data[j-1,0]) 
                    && (data[j,3] ==  data[j-1,3] ))
                {
                    int temp = data[j-1,1];
                    data[j-1,1] = data[j,1];
                    data[j,1] = temp;
 
                    temp = data[j-1,2];
                    data[j-1,2] = data[j,2];
                    data[j,2] = temp;
                                                   
                    temp = data[j-1,3];
                    data[j-1,3] = data[j,3];
                    data[j,3] = temp; 
                    
                    temp = data[j-1,0];
                    data[j-1,0] = data[j,0];
                    data[j,0] = temp;                         
                    
                                          
                    exit = false;
                }
            }
        }
        while(exit == false);

        
    
        Console.WriteLine();

            for (int i = 0 ;  i < size; i++)
                Console.WriteLine(data[i,0] +" " + data[i,1] + " " 
                    + data[i,2] + " "+  data[i,03]);
            
    }
}
