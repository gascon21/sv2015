// Sum big numbers

using System;

public class SumBigNumbers
{
    public static string Sum(string num1, string num2)
    {
        string result="";
        bool carry = false;

        if(num1.Length > num2.Length)
        {
            string zeroes = new String('0',num1.Length-num2.Length);
            num2 = zeroes + num2;
        }
        else if(num2.Length>num1.Length)
        {
            string zeroes = new String('0',num2.Length-num1.Length);
            num1 = zeroes + num1;
        }
        
        int pos = num1.Length-1;

        while(pos >= 0)
        {
            int n1 = Convert.ToInt32(num1.Substring(pos, 1));
            int n2 = Convert.ToInt32(num2.Substring(pos, 1));

            int sum = n1+n2;
            if(carry)
            {
                sum++;
                carry=false;
            }
            if(sum >= 10)
            {
                sum %= 10;
                carry = true;
            }
            result = "" + sum + result;
            pos--;
        }
                
        if(carry)
            result="1"+result;

        return result;
    }
    
    public static void Main()
    {
        // Tests
        if (Sum("2", "3") != "5")
            Console.WriteLine("Incorrect 2+3: " + Sum("2", "3"));
        if (Sum("5", "5") != "10")
            Console.WriteLine("Incorrect 5+5: " + Sum("5", "5"));
        if (Sum("25", "36") != "61")
            Console.WriteLine("Incorrect 25+36: " + Sum("25", "36"));
        if (Sum("555", "555") != "1110")
            Console.WriteLine("Incorrect 555+555: " + Sum("555", "555"));
                
        // Real program logic
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        Console.WriteLine(Sum(num1, num2));
    }
}
