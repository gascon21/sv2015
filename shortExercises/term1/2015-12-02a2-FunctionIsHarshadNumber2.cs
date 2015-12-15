// David Gascón López
// Function IsHarshadNumber

using System;
public class FunctionIsHarshadNumber2
{
    public static bool IsHarshadNumber(int n)
    {
        string number = Convert.ToString(n);
        
        int sum = 0;
        
        for(int i=0; i<number.Length; i++)
            sum += Convert.ToInt32( number.Substring(i,1) );
        
        return (n % sum == 0);
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
