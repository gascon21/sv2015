/*
Structs + List + Persistence (XML)
Note: this program will result in a run error: 
Generic Lists cannot be serialized using SOAP
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

[Serializable]
public class ComputersDatabase
{
    [Serializable]
    public struct RAM
    {
        public string unit;
        public float size;

    }
    [Serializable]
    public struct computer
    {
        public string brand;
        public string model;
        public string comment;
        public int year;
        public RAM memory;

    }

    public static void Main()
    {
        List<computer> computers;
        if (File.Exists("saveComputer.xml"))
        {
            computers = Load();
        }
        else
        {
            computers = new List<computer>();
        }
        char option;
        bool finished = false;
        Console.WriteLine("Welcome to the official computers database");
        do
        {
            Console.WriteLine("1.Add a new computer");
            Console.WriteLine("2.View all computers");
            Console.WriteLine("3.Search a computer");
            Console.WriteLine("4.Update a computer");
            Console.WriteLine("5.Delete a computer");
            Console.WriteLine("6.insert a computer in a certain position");
            Console.WriteLine("7.Sort computers alphabetically");
            Console.WriteLine("8.remove extra spaces");
            Console.WriteLine("Q.Quit");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    computer compNew = new computer();
                    Console.WriteLine("Enter the brand:");
                    do
                    {
                        compNew.brand = Console.ReadLine();
                        if (compNew.brand == "")
                            Console.WriteLine("Invalid brand. Enter a valid One");
                    } while (compNew.brand == "");

                    Console.WriteLine("Enter the name of the model");
                    do
                    {
                        compNew.model = Console.ReadLine();
                        if (compNew.model.Length > 50)
                            Console.WriteLine("Too long name, insert the model again:");
                    } while (compNew.model.Length > 50);

                    Console.WriteLine("Enter the year");
                    compNew.year = Convert.ToInt32(Console.ReadLine());
                    if (compNew.year < 1900)
                        compNew.year = 0;

                    Console.WriteLine("Enter the RAM unit (e.g. Kb)");
                    compNew.memory.unit = Console.ReadLine();

                    Console.WriteLine("Enter the RAM size (e.g. 64)");
                    compNew.memory.size = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Enter the comment");
                    compNew.comment = Convert.ToString(Console.ReadLine());

                    computers.Add(compNew);
                    break;

                case '2':
                    if (computers.Count == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        int cont = 0;
                        do
                        {
                            Console.Write("Computer {0}:", cont + 1);
                            Console.Write("{0}", computers[cont].brand);
                            Console.Write(" - {0}", computers[cont].model);
                            Console.WriteLine();
                            cont++;
                            if (cont % 24 == 0)
                                Console.WriteLine("Press Enter to continue");
                        } while (cont < computers.Count);
                    }
                    Console.WriteLine();
                    break;

                case '3':
                    Console.WriteLine("Enter the text you want to search for: ");
                    string search = Console.ReadLine().ToUpper();
                    bool found = false;
                    for (int k = 0; k < computers.Count; k++)
                    {
                        if (computers[k].brand.ToUpper().Contains(search)
                            || computers[k].model.ToUpper().Contains(search)
                            || computers[k].comment.ToUpper().Contains(search))
                        {
                            found = true;
                            Console.WriteLine("Computers found");
                            Console.Write("Brand: {0}", computers[k].brand);
                            Console.WriteLine("Model: {0}", computers[k].model);
                            if (computers[k].year == 0)
                                Console.WriteLine("Unknown year");
                            else
                                Console.Write("Year: {0}", computers[k].year);
                            Console.Write("RAM: " + computers[k].memory.size +
                                " " + computers[k].memory.unit);
                            Console.Write("Comment: {0}", computers[k].comment);
                        }
                    }
                    if (!found)
                        Console.WriteLine("No computers found");
                    Console.WriteLine();
                    break;

                case '4':
                    if (computers.Count == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        Console.WriteLine("Enter the position to update: ");
                        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (pos > computers.Count - 1 || pos < 0)
                            Console.WriteLine("Invalid position");
                        else
                        {
                            string text;
                            Console.WriteLine("Computer number {0}", pos + 1);
                            Console.Write("Brand ({0}): ", computers[pos].brand);
                            computer compChange = new computer();
                            text = Console.ReadLine();
                            if (text != "")
                                compChange.brand = text;

                            Console.Write("Model ({0}): ", computers[pos].model);
                            text = Console.ReadLine();
                            if (text != "")
                                compChange.model = text;

                            Console.WriteLine("Year ({0}): ", computers[pos].year);
                            text = Console.ReadLine();
                            if (text != "")
                                compChange.year = Convert.ToInt32(text);

                            Console.WriteLine("RAM size: {0}", computers[pos].memory.size);
                            text = Console.ReadLine();
                            if (text != "")
                                compChange.memory.size = Convert.ToInt32(text);

                            Console.WriteLine("RAM unit: {0}", computers[pos].memory.unit);
                            text = Console.ReadLine();
                            if (text != "")
                                compChange.memory.unit = text;

                            Console.WriteLine("Comment: {0}", computers[pos].comment);
                            text = Console.ReadLine();
                            if (text != "")
                                compChange.comment = text;

                            computers[pos] = compChange;
                        }
                    }
                    Console.WriteLine();
                    break;

                case '5':
                    if (computers.Count == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        Console.WriteLine("Select the position of the computer to delete: ");
                        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (pos > computers.Count - 1 || pos < 0)
                            Console.WriteLine("Invalid position");
                        else
                            computers.RemoveAt(pos);
                    }
                    Console.WriteLine();
                    break;

                case '6':
                    if (computers.Count == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        Console.WriteLine("Enter the position to insert a new computer: ");
                        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (pos > computers.Count || pos < 0)
                            Console.WriteLine("Invalid position");
                        else
                        {
                            computer addNew = new computer();
                            computers.Add(addNew);
                            for (int i = pos + 1; i < computers.Count; i++)
                                computers[i] = computers[i - 1];
                            Console.WriteLine("Enter the brand:");
                            do
                            {
                                addNew.brand = Console.ReadLine();
                                if (addNew.brand == "")
                                {
                                    Console.WriteLine("Invalid brand. Enter a valid One");
                                }
                            } while (addNew.brand == "");

                            Console.WriteLine("Enter the name of the model");
                            do
                            {
                                addNew.model = Console.ReadLine();
                                if (addNew.model.Length > 50)
                                {
                                    Console.WriteLine("Too long name, insert the model again:");
                                }
                            } while (addNew.model.Length > 50);

                            Console.WriteLine("Enter the year");
                            addNew.year = Convert.ToInt32(Console.ReadLine());
                            if (addNew.year < 1900)
                            {
                                addNew.year = 0;
                            }

                            Console.WriteLine("Enter the RAM unit (e.g. Kb)");
                            addNew.memory.unit = Console.ReadLine();

                            Console.WriteLine("Enter the RAM size (e.g. 64)");
                            addNew.memory.size = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Enter the comment");
                            addNew.comment = Console.ReadLine();

                            computers[pos] = addNew;
                        }
                    }
                    Console.WriteLine();
                    break;

                case '7':
                    computers.Sort((x, y) => string.Compare(x.brand, y.model));

                    Console.WriteLine("Data sorted");
                    Console.WriteLine();
                    break;

                case '8':
                    computer temp;
                    for (int i = 0; i < computers.Count; i++)
                    {
                        temp = computers[i];
                        temp.comment.Trim();
                        computers[i] = temp;
                    }
                    break;

                case 'q':
                case 'Q':
                    finished = true;
                    Console.WriteLine("Thanks for using our services, have a nice day!");
                    Save(computers);
                    break;

                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        } while (!finished);
    }

    public static void Save(List<computer> objeto)
    {
        IFormatter formatter = new SoapFormatter();
        Stream stream = new FileStream("saveComputer.xml",
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, objeto);
        stream.Close();
    }

    public static List<computer> Load()
    {
        List<computer> objeto;
        IFormatter formatter = new SoapFormatter();
        Stream stream = new FileStream("saveComputer.xml",
            FileMode.Open, FileAccess.Read, FileShare.Read);
        objeto = (List<computer>)formatter.Deserialize(stream);
        stream.Close();
        return objeto;
    }
}

