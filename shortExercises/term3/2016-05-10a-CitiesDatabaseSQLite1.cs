// Cities Database, version using SQLite

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

public class CitiesDatabase
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
        List<city> cities = new List<city>();
        byte option;

        if (File.Exists("cities.sqlite"))
        {
            try
            {
                SQLiteConnection connection =
                    new SQLiteConnection(
                    "Data Source=cities.sqlite;Version=3;New=False;Compress=True;");
                connection.Open();

                string query = "select * from cities";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                SQLiteDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    city tempCity;
                    tempCity.name = Convert.ToString(data[0]);
                    tempCity.numberInhabitants = Convert.ToUInt32(data[1]);
                    cities.Add(tempCity);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Database error: {0}", e.Message);
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
                        SQLiteConnection connection =
                            new SQLiteConnection(
                            "Data Source=cities.sqlite;Version=3;New=True;Compress=True;");
                        connection.Open();

                        string drop = "drop table if exists cities;";
                        SQLiteCommand cmd = new SQLiteCommand(drop, connection);
                        cmd.ExecuteNonQuery();

                        string creation = "create table cities ("
                            + " name varchar(50) primary key, inhabitants int);";
                        cmd = new SQLiteCommand(creation, connection);
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i < cities.Count; i++)
                        {
                            string insertion = "insert into cities values "
                                +"('"+ cities[i].name + "', "
                                + cities[i].numberInhabitants  + ");";
                            cmd = new SQLiteCommand(insertion, connection);
                            cmd.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Database error: {0}", e.Message);
                    }
                    Console.WriteLine("Bye!");
                    break;
            }
        }
        while (option != 0);

    }
}