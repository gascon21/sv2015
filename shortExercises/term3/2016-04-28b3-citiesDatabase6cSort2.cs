// Cities Database, version using List + Sort + lambda

using System;
using System.Collections.Generic;
using System.IO;

public class citiesDatabase
{
    struct city
    {
        public string name;
        public uint numberInhabitants;
    }

    enum options
    {
        EXIT, ADD, VIEW, MODIFY, SEARCH, INSERT,
        DELETE, CAPITALIZE, SORT
    };

    public static void Main()
    {
        //const int SIZE = 500;
        //city[] cities = new city[SIZE];
        List<city> cities = new List<city>();
        //int numCities = 0;
        byte option;

        if (File.Exists("citiesDB.bd"))
        {
            try
            {
                StreamReader inFile = File.OpenText("citiesDB.bd");
                string line;
                do
                {
                    line = inFile.ReadLine();
                    if (line != null)
                    {
                        string[] parts = line.Split(':');
                        city tempCity;
                        tempCity.name = parts[0];
                        tempCity.numberInhabitants =
                            Convert.ToUInt32(parts[1]);
                        cities.Add(tempCity);
                    }
                }
                while (line != null);
                inFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/Ouput error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: {0}", ex.Message);
            }
        }

        do
        {
            Console.WriteLine("1 - Add a new city");
            Console.WriteLine("2 - View all cities");
            Console.WriteLine("3 - Modify a record");
            Console.WriteLine("4 - Search in the records");
            Console.WriteLine("5 - Insert a new record");
            Console.WriteLine("6 - Delete a record");
            Console.WriteLine("7 - Correct the capitalization of the names");
            Console.WriteLine("8 - Sort by name");
            Console.WriteLine("0 - Exit");
            option = Convert.ToByte(Console.ReadLine());

            switch (option)
            {
                case (int)options.ADD:
                    city tempCity;
                    Console.Write("Enter the name of city {0}: ", cities.Count + 1);
                    tempCity.name = Console.ReadLine();
                    Console.Write(
                        "Enter the number of inhabitants of city {0}: ",
                            cities.Count + 1);
                    tempCity.numberInhabitants =
                        Convert.ToUInt32(Console.ReadLine());
                    cities.Add(tempCity);
                    break;

                case (int)options.VIEW:
                    for (int i = 0; i < cities.Count; i++)
                        Console.WriteLine("City {0}: {1} [ {2} ]",
                            i + 1, cities[i].name,
                            cities[i].numberInhabitants);
                    break;

                case (int)options.MODIFY:
                    Console.Write("Enter the number of city for modify: ");
                    int n = Convert.ToInt32(Console.ReadLine()) - 1;
                    city modCity = cities[n];

                    Console.Write("Enter the new name of city {0}: ",
                        modCity.name);
                    string newName = Console.ReadLine();
                    if (newName != "")
                        modCity.name = newName;

                    Console.Write
                        ("Enter the new numbers of inhabitants for {0}: ",
                            modCity.name);
                    string newNumberString = Console.ReadLine();
                    if (newNumberString != "")
                    {
                        uint newNumber = Convert.ToUInt32(newNumberString);
                        modCity.numberInhabitants = newNumber;
                    }
                    cities[n] = modCity;
                    break;

                case (int)options.SEARCH:
                    Console.Write("What do you want to search? ");
                    string parcialSearch = Console.ReadLine();

                    for (int i = 0; i < cities.Count; i++)
                        if (cities[i].name.ToLower().
                                Contains(parcialSearch.ToLower()))
                            Console.WriteLine("City {0}: {1} [ {2} ]",
                                i + 1, cities[i].name,
                                cities[i].numberInhabitants);
                    break;

                case (int)options.INSERT:
                    Console.Write("Specify the position: ");
                    int insertPosition = Convert.ToInt32(
                        Console.ReadLine()) - 1;
                    city insCity;

                    Console.Write("Enter the name of city: ");
                    insCity.name = Console.ReadLine();

                    Console.Write(
                        "Enter the number of inhabitants of city: ");
                    insCity.numberInhabitants =
                        Convert.ToUInt32(Console.ReadLine());

                    cities.Insert(insertPosition, insCity);
                    break;

                case (int)options.DELETE:
                    Console.Write("Enter the record to delete: ");
                    int deletePosition =
                        Convert.ToInt32(Console.ReadLine()) - 1;

                    cities.RemoveAt(deletePosition);
                    break;

                case (int)options.CAPITALIZE:
                    for (int i = 0; i < cities.Count; i++)
                    {
                        string corrected = cities[i].
                            name.Substring(0, 1).ToUpper();
                        for (int j = 1; j < cities[i].name.Length; j++)
                        {
                            if (cities[i].name[j - 1] == ' ')
                                corrected += Char.ToUpper(cities[i].name[j]);
                            else
                                corrected += Char.ToLower(cities[i].name[j]);
                        }
                        city capCity = cities[i];
                        capCity.name = corrected;
                        cities[i] = capCity;
                    }
                    Console.WriteLine("All name of cities corrected");

                    break;

                case (int)options.SORT:
                    cities.Sort((x, y) => string.Compare(x.name, y.name));
                    Console.WriteLine("All data sorted by name");
                    break;

                case (int)options.EXIT:
                    try
                    {
                        StreamWriter outFile = File.CreateText("citiesDB.bd");
                        for (int i = 0; i < cities.Count; i++)
                        {
                            outFile.WriteLine(cities[i].name + ":" +
                                cities[i].numberInhabitants);
                        }
                        outFile.Close();
                    }
                    catch (PathTooLongException)
                    {
                        Console.WriteLine("Path too long.");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Input/Ouput error: {0}", ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unexpected error: {0}", ex.Message);
                    }
                    Console.WriteLine("Bye!");
                    break;
            }
        }
        while (option != 0);

    }
}
