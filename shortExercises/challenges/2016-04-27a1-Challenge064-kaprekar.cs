// Jose Muñoz
// IsKaprekarNumber

using System;

public class Kaprekar
{
    public static bool IsKaprekarNumber (long number)
    {
        if ((number == 1) || (number == 9))
            return true;
            
        long squared = number * number;
        string squaredStr = Convert.ToString(squared);
        int size = squaredStr.Length;
        string num1, num2;
        for (int i = 1; i < size; i++)
        {
            
            num1 = squaredStr.Substring(0,i);
            num2 = squaredStr.Substring(i, size-i);
            if(Convert.ToInt32(num2) != 0 )
            {
                int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                if (number == sum)
                    return true;
            }
        }
        return false;
    }
    
    
    public static void Main()
    {
        long num;
        do
        {
            num = Convert.ToInt64(Console.ReadLine());
            if (num > 0 && num < 65536)
            {
                
                if (IsKaprekarNumber(num))
                {
                    Console.WriteLine("SI");
                }
                else
                    Console.WriteLine("NO");
            }
        } while (num > 0 && num < 65536);
    }
}
