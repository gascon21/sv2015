// Ruben Blanco
// Program: StatisticsArray

/*
Create a statistical program which will allow the user to:

- Add new data (a floating point number)
- See all data entered
- Find an item, to see whether it has been entered or not
- View a summary of statistics: amount of data, sum, average, 
  maximum, minimum
- Exit the program

These options must appear as a menu. Each option will be chosen by a 
number or a letter.

The program must reserve space for a maximum of 1000 data, but keep 
count of how many data actually exist.
*/

using System;

public class StatisticsArray
{
    public static void Main()
    {
        const int SIZE = 1000;
        double[] number = new double[SIZE];
        byte option;
        double search;
        double maxNumber;
        double minNumber;
        double sum;
        double average;
        
        uint numElements = 0;
        
        do
        {
            Console.WriteLine("1.-Add a number");
            Console.WriteLine("2.-View last numbers");
            Console.WriteLine("3.-Find a number");
            Console.WriteLine("4.-Statistics");
            Console.WriteLine("0.-Exit");
            
            option = Convert.ToByte(Console.ReadLine());
            
            switch (option)
            {
                case 0:
                
                    break;
                    
                case 1:
                    
                    Console.Write("Enter a number: ");
                    number[numElements] = Convert.ToDouble(Console.ReadLine());
                    
                    numElements++;
                    Console.WriteLine();
                    break;
                    
                case 2:

                    for (uint i = 0; i < numElements; i++)
                        Console.WriteLine("Number {0}: {1}", i+1, number[i]);
                    
                    Console.WriteLine();
                    break;
                    
                case 3:
                
                    bool found = false;
                    Console.Write("Enter the number to find: ");
                    search = Convert.ToDouble(Console.ReadLine());
                    
                    for(int i=0;i<SIZE;i++)
                    {
                        if (search == number[i])
                            found = true;
                    }
                    
                    if (found)
                        Console.WriteLine("Found");
                    else
                        Console.WriteLine("Not found");
                        
                    Console.WriteLine();
                    break;
                    
                case 4:
                    Console.WriteLine("Statistics:");
                    
                    maxNumber = number[0];
                    minNumber = number[0];
                    sum = 0;
                    average = 0;
                    
                    for(byte i=0;i<numElements;i++)
                    {
                        if(maxNumber<number[i])
                            maxNumber = number[i];
                            
                        if(minNumber>number[i])
                            minNumber = number[i];
                            
                        sum = sum+number[i];
                        average = sum/numElements;
                        
                    }
                    Console.WriteLine("Amount of data: {0} numbers", 
                        numElements);
                    Console.WriteLine("Sum: {0}", sum);   
                    Console.WriteLine("Average: {0}", average);
                    Console.WriteLine("Maximun number: {0}", maxNumber);
                    Console.WriteLine("Minimun number: {0}", minNumber);
                    
                    Console.WriteLine();
                    break;
                    
                default:
                    Console.WriteLine("Unknown option");
                    break;
            }
        }
        while(option!=0);
    }
}
