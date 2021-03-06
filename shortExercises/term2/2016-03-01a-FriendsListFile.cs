﻿// Friends database 2

using System;
using System.Collections.Generic;
using System.IO;

public class Friend
{
    public string Name { get; set; }
    public ushort Year { get; set; }
}

public class FriendsDatabase2
{
    

    public static void Main()
    {
        List<Friend> persons = new List<Friend>();
        char opcion;

        if (File.Exists("friends.dat"))
        {
            StreamReader inputFile = new StreamReader("friends.dat");
            string line;
            do
            {
                line = inputFile.ReadLine();
                if (line != null)
                {
                    string[] parts = line.Split('|');
                    Friend f = new Friend();
                    f.Name = parts[0];
                    f.Year = Convert.ToUInt16(parts[1]);
                    persons.Add(f);

                }
            }
            while (line != null);
            inputFile.Close();
        }

        ConsoleKeyInfo key;

        do
        {
            Console.WriteLine("1.- Add a new name");
            Console.WriteLine("2.- Show all data");
            Console.WriteLine("X.- Exit");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'x':
                    opcion = 'X';
                    break;

                case 'X':
                    break;

                case '1':
                    string name;
                    do
                    {
                        Console.Write("Add a new name of friend {0}: ",
                                persons.Count + 1);
                        name = Console.ReadLine();

                        if (name.Length > 40)
                            Console.WriteLine("40 letters max");
                    }
                    while (name.Length > 40);

                    ushort year;
                    do
                    {
                        Console.Write("Add a birth year of friend {0}: ",
                                persons.Count + 1);
                        year = Convert.ToUInt16(
                                Console.ReadLine());

                        if (year < 1850 || year > 2100)
                            Console.WriteLine("Birth year must be between"
                                    + " 1850 and 2100");
                    }
                    while (year < 1850 || year > 2100);

                    Console.WriteLine();

                    Friend f = new Friend();
                    f.Name = name;
                    f.Year = year;
                    persons.Add(f);
                    break;

                case '2':
                    if (persons.Count == 0)
                    {
                        Console.WriteLine("The data don't exist");
                    }
                    else
                    {
                        for (int i = 0; i < persons.Count; i++)
                        {
                            if (persons[i].Name.Length <= 30)
                                Console.WriteLine("{0}: {1} born in {2}", i + 1,
                                        persons[i].Name, persons[i].Year);
                            else
                                Console.WriteLine("{0}: {1}... born in {2}",
                                        i + 1, persons[i].Name.Substring(0, 30),
                                        persons[i].Year);

                            if (i % 20 == 19)
                            {
                                Console.WriteLine("Press Enter to countinue");
                                do
                                    key = Console.ReadKey();
                                while (key.Key != ConsoleKey.Enter);
                            }
                        }
                    }

                    Console.WriteLine();
                    break;
            }
        }
        while (opcion != 'X');

        StreamWriter file = new StreamWriter("friends.dat");
        foreach( Friend f in persons)
        {
            file.WriteLine(f.Name + "|" + f.Year);
        }
        file.Close();


        Console.WriteLine("Bye!");
    }
}