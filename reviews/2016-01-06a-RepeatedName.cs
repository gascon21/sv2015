using System;

class RepeatedName
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("How many times do you want me to write it? ");
        int times = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < times; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(name);
            else
                Console.WriteLine("--" + name + "--");
        }
    }
}

