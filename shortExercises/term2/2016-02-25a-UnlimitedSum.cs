// Unlimited sum

using System;
using System.Collections.Generic;

class ListOfDoubles
{
    static List<double> list;

    static void Main(string[] args)
    {
        list = new List<double>();
        string option = "";
        bool finished = false;

        do
        {
            Console.Write("Number or command? ");
            option = Console.ReadLine();

            switch(option)
            {
                case "end": finished = true; break;
                case "view": ShowData(); break;
                case "sum": SumData(); break;
                default: AddData(option); break;
            }
        
        }
        while(!finished);

    }

    public static void AddData(string option)
    {
        try
        {
            list.Add(Convert.ToInt32(option));
        }
        catch (Exception)
        {
            
           Console.WriteLine("Error, not a number");
        }                
    }

    public static void ShowData()
    {
        foreach (double item in list)
        {
            Console.WriteLine(item);
        }
    }

    public static void SumData()
    {

        double result = 0;
        foreach (double item in list)
        {
            result += item;
        }
        Console.WriteLine(result);
    }
}
