// David Gascón López
// Function IsHarshadNumber

using System;
public class FunctionIsHarshadNumber
{
    public static bool IsHarshadNumber(int n)
    {
        string number = Convert.ToString(n);
        
        int sum = 0;
        
        foreach (char num in number)
        {
            sum += (num - '0');
        }
        
        if (n % sum == 0)
            return true;
        else
            return false;
    }
    
    public static void Main()
    {
        if ( IsHarshadNumber(4) )
            Console.WriteLine("4 is a Harshad number");
            
        if ( IsHarshadNumber(152) )
            Console.WriteLine("152 is a Harshad number");

        if ( ! IsHarshadNumber(121))
            Console.WriteLine("121 is not a Harshad number");
        
        Console.Write("Enter the number:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (IsHarshadNumber (n))
            Console.WriteLine("{0} is a Harshad number", n);
        else
            Console.WriteLine("{0} is not a Harshad number", n);
    }
}
