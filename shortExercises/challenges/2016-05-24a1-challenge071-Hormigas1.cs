// Victor Carretero Blasco, Sacha Van de sijpe Bueno

using System;

namespace hormigaChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases;
            do
            {
                cases = Convert.ToInt32(Console.ReadLine());
                if (cases != 0)
                {
                    string line = Console.ReadLine();
                    string[] numbers = line.Split(' ');
                    bool found = false;
                    
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int numberToCompare = Convert.ToInt32(numbers[i]);
                        int sum = 0;
                        for (int secondNumber = i+1; secondNumber<numbers.Length; secondNumber++)
                        {
                            if (numberToCompare < sum)
                                break;

                            sum += Convert.ToInt32(numbers[secondNumber]);
                        }
                        if (numberToCompare == sum)
                        {
                            Console.WriteLine("SI " + (i + 1));
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("NO");
                    }
                }
            } while (cases != 0);
        }
    }
}
