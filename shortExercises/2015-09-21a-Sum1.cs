// Miguel Moya Ortega
// Sum three numbers

/*
Write a C# program to ask the user for three numbers and display their sum. The 
first line must be a comment with your name and surname. It MUST look as 
follows:

Enter the first number to sum
12
Enter the second number to sum
23
Enter the third number to sum
2
Result: 12 + 23 + 2 = 37
*/

using System;
public class SumThreeNumbers
{
    public static void Main()
    {
        int x, y, z;
        int sum;
        
        Console.WriteLine("Enter the first number to sum");
        x = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Enter the second number to sum");
        y = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Enter the third number to sum");
        z = Convert.ToInt32( Console.ReadLine() );
        
        sum = x + y + z;
        Console.Write ("Result: ");
        Console.Write (x);
        Console.Write (" + ");
        Console.Write (y);
        Console.Write (" + ");
        Console.Write (z);
        Console.Write (" = ");
        Console.WriteLine (sum);
        
    }
}
