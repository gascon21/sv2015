// Friends database 2

using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;

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

        if (File.Exists("friends.sqlite"))
        {
            try
            {
                SQLiteConnection connection =
                    new SQLiteConnection(
                    "Data Source=friends.sqlite;Version=3;New=False;Compress=True;");
                connection.Open();

                string query = "select * from friend";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                SQLiteDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Friend tempFriend = new Friend();
                    tempFriend.Name = Convert.ToString(data[0]);
                    tempFriend.Year = Convert.ToUInt16(data[1]);
                    persons.Add(tempFriend);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Database error: {0}", e.Message);
            }
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

        try
        {
            SQLiteConnection connection =
                new SQLiteConnection(
                "Data Source=friends.sqlite;Version=3;New=True;Compress=True;");
            connection.Open();

            string drop = "drop table if exists friend;";
            SQLiteCommand cmd = new SQLiteCommand(drop, connection);
            cmd.ExecuteNonQuery();

            string creation = "create table friend ("
                + " name varchar(100), "
                + "year number);";
            cmd = new SQLiteCommand(creation, connection);
            cmd.ExecuteNonQuery();

            for (int i = 0; i < persons.Count; i++)
            {
                string insertion = "insert into friend values "
                    + "('" + persons[i].Name + "', '"
                    + persons[i].Year + "');";
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
    }
}
