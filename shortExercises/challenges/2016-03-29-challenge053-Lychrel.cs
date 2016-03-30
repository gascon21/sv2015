// Gonzalo García Soler
// Challenge 53: Lychrel numbers

using System;

public class LychrelNumbers
{
    public static int Reverse(int input)
    {
        string numberString = input.ToString();
        string reversedNumber = "";

        for (int i = numberString.Length - 1; i >= 0; i--)
            reversedNumber += numberString[i];

        int number = Convert.ToInt32(reversedNumber);

        return number;
    }

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

    public static void Main()
    {
        const int MAXSIZE = 1000000000;     
      
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            bool finished = false;
            int numberReversed = 0;
            int iterations = 1;
            int result = 0;

            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 10)
            {
                while (!finished)
                {
                    if (number < MAXSIZE)
                    {
                        numberReversed = Reverse(number);

                        if (IsPalindrome(number + numberReversed))
                        {
                            finished = true;
                            result = numberReversed + number;
                            Console.WriteLine(iterations + " " + result);
                        }
                        else
                        {
                            iterations++;
                            number = numberReversed + number;
                        }
                    }
                    else
                    {
                        finished = true;
                        Console.WriteLine("Lychrel?");
                    }
                }
            }
            else
            {
                Console.WriteLine("0 {0}",number);
            }              
        }
    }
}
