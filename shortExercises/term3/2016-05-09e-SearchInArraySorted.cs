// Search in array (v2: sorted)
// Adrian Navarro Garcia

using System;
namespace NumerosRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool encontrado = false;
            int[] myArray = new int[5000];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = r.Next(1, 100000);
            }
            Array.Sort(myArray);

            string num2 = " ";
            do
            {
                Console.Write("Enter number to search: ");
                num2 = Console.ReadLine();

                if (num2 != "end")
                {
                    int comparisons = 0;
                    int num = Convert.ToInt32(num2);
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        comparisons++;
                        if (myArray[i] == num)
                        {
                            Console.WriteLine("Found in pos " + (i+1));
                            encontrado = true;
                            break;
                        }
                        if (myArray[i] > num)
                        {
                            break;
                        }
                    }
                    if (!encontrado)
                        Console.WriteLine("Not found");
                    Console.WriteLine("Comparisons: "+comparisons);
                }
            } while (num2 != "end");
        }
    }
}
