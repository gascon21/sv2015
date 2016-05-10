// Chen Chao
// 09-05-2016

using System;

public class Multiply
{
    public static string AddNums(string text1, string text2)
    {
        string max = text1.Length > text2.Length ? text1 : text2;
        string min = text1.Length < text2.Length ? text1 : text2;
        long dif = max.Length - min.Length;
        
        min = new String('0', (int)dif) + min;
        string total = "";
        int result = 0;
        bool overTen = false;
        
        for (int i = max.Length - 1; i >= 0; i--)
        {
            int n1 = max[i] - '0';
            int n2 = min[i] - '0';
            result = n1 + n2;
            
            if (overTen)
            {
                result++;
                overTen = false;
            }
            if (result >= 10)
            {
                result %= 10;
                overTen = true;
            }
            total = "" + result + total;
        }
        
        if (overTen)
            total = "1" + total;
        return total;
    }
    
    public static string MultiplyNums(string text1, char text2)
    {
        string total = "";
        int result = 0;
        bool overTen = false;
        int n1 = 0;
        int n2 = 0;
        int mult = Convert.ToInt32("" + text2);
        for (int i = text1.Length - 1; i >= 0; i--)
        {
            n1 = text1[i] - '0';
            result = n1 * mult;
            
            if (overTen)
            {
                result += n2;
                overTen = false;
            }
            
            n2 = result / 10;
            result %= 10;
            overTen = true;
            total = "" + result + total;
        }
        
        if (overTen)
            total = "" + n2 + total;
        
        return total;
    }
    
    public static void Main()
    {
        Console.Write("Enter the long number: ");
        string num = Console.ReadLine();
        Console.Write("Enter the multiplier: ");
        string mult = Console.ReadLine();
        string total = "";
        
        for (int i = mult.Length - 1; i >= 0; i--)
        {
            total=AddNums(total, MultiplyNums(num, mult[i]) 
                + new string('0',mult.Length - 1 - i ));
        }
        
        while (total.StartsWith("0"))
            total = total.Substring(1);
        
        Console.WriteLine("The result is: {0}", total);
    }
}
