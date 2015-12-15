/* Juan Salinas Gómez
 * Median
 * 11/11/15
 */

/*
Create a C# program to ask the user for an undetermined amount of data 
and display their median (the data in the middle part of the ordered 
series).

It should look behave this:

Enter number: 3
Enter number: 1
Enter number: 2
Enter number:
The median is 2

Enter number: 3
Enter number: 1
Enter number: 2
Enter number: 4
Enter number:
The median is 2.5
*/

using System;

public class Median
{
    public static void Main()
    {
        const int SIZE = 200000000;
        double[] data = new double[SIZE];
        string num;
        double number, dataT;
        int i, j; 
        int count = 0;
        
        // First, ask for data
        do
        {
            Console.Write("Enter number: ");
            num = Console.ReadLine();
            
            if (num != "")
            {
                number = Convert.ToDouble(num);
                data[count] = number;
                count++;
            }
        }
        while (num != ""); 
          
        // Then, sort
        for (i = 0; i < count - 1; i++)
        {
            for (j = i + 1; j < count; j++)
            {
                if (data[i] > data[j])
                {
                    dataT = data[i];
                    data[i] = data[j];
                    data[j] = dataT;
                }
            }
        }
        
        // And finally, display the median
        if (count % 2 == 1)   // Odd amount of data
            Console.WriteLine(data[count / 2]);
        else                  // Even amount of data
            Console.WriteLine(
                (data[count/2-1]+data[count/2]) / 2);
    }
}
