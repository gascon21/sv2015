// Sum of all Emirps up to n
// Gonzalo García Soler

// Minor corrections by Nacho:
// - do-while to allow several input data
// - measuring times, to know the effect of improvements

using System;

public class Emirps
{
    public static bool IsPalindrome(int number)
    {
        string tempNumber = Convert.ToString(number);

        int left = 0;
        int right = tempNumber.Length - 1;

        while (left < right)
        {
            if (tempNumber[left] != tempNumber[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    public static bool IsPrime(int number)
    {
        int dividers = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                dividers++;
        }

        return dividers == 2 ? true : false;
    }

    public static int Reverse(string input)
    {
        string ReverseNumber = "";

        for (int i = input.Length-1; i >= 0; i--)
            ReverseNumber += input[i];
        
        int number = Convert.ToInt32(ReverseNumber);

        return number;
    }

    public static void Main()
    {
        string inputStr;
        DateTime start = DateTime.Now;
        bool debugging = true;

        do
        {
            inputStr = Console.ReadLine();
            
            if ((inputStr == null) || (inputStr == ""))
                break;
            
            int sum = 0;
            int input = Convert.ToInt32(inputStr);
            
            if (debugging)
            {
                start = DateTime.Now;
                Console.WriteLine("Started at: " + start);
            }

            for (int i = 1; i < input; i++)
            {
                int numberReversed = Reverse(i.ToString());
               
                if (IsPrime(numberReversed) && IsPrime(i) && !IsPalindrome(i))
                    sum += i;
            }
            Console.WriteLine(sum);
            
            if (debugging)
            {
                Console.WriteLine("Finished at: " + System.DateTime.Now);
                Console.WriteLine("Seconds taken : {0}", 
                    DateTime.Now - start);
                Console.WriteLine();
            }
            
        }
        while (true); // "break" inside: if no data
    }
}
