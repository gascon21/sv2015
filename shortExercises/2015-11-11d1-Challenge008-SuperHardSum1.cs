// Jorge Montalvo Blanes

/*
Your amazing program should calculate the sum if the numbers given in 
each line, and output on line for each question with the response. 
Numbers can be negative, really big and lines contain extra spaces, so 
make your program resistant to input.

Your program will need to read from standard input, line by line till 
the end of the input. Consider each line a different question. For each 
line you read, output the sum of all the given numbers.

Sample input and output

Sample input
123456789012 1
2 3
4   5 -1

Sample output
123456789013
5
8

Procedencia:
Concurso Tuenti 2011, pregunta 1
*/

using System;

public class Challenge008
{
    public static void Main()
    {
        string input = Console.ReadLine();
        
        while (input != "")
        {
            // Remove redundant spaces
            for(int j=0;j<input.Length;j++)
            {
                if(j>0) 
                    if(input[j] == ' ' && input[j-1] == ' ')
                    {
                        input = input.Remove(j,1);
                        j--;
                    }
            }
            
            // Finally, split and sum
            string[] numbers = input.Split(' ');
            
            double sum = 0;
            for(int i =0;i<numbers.Length;i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine(sum);
            input = Console.ReadLine();
        }
    }
}
