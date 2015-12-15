/*
Expand the cities database, adding the following options:

5 .- Insert a new record (in a specified position, moving the following 
     ones to the right)

6 .- Delete a record (moving the following ones to the left so that no
     empty spaces are left)

(Note: you might need to have a look at topic 4.1.4 in you class book).
*/

using System;

public class citiesDatabase
{
    struct city
    {
        public string name;
        public uint numberInhabitants;
    }
    
    public static void Main()
    {
        const int SIZE = 500;
        city[] cities = new city[SIZE];
        byte option;
        int numCities = 0;
        
        do
        {
            Console.WriteLine("1 - Add a new city");
            Console.WriteLine("2 - View all cities");
            Console.WriteLine("3 - Modify a record");
            Console.WriteLine("4 - Search in the records");
            Console.WriteLine("5 - Insert a new record");
            Console.WriteLine("6 - Delete a record");
            Console.WriteLine("0 - Exit");
            option = Convert.ToByte(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    Console.Write("Enter the name of city {0}: ",numCities+1);
                    cities[numCities].name = Console.ReadLine();
                    
                    Console.Write(
                        "Enter the number of inhabitants of city {0}: ",
                            numCities+1);
                    cities[numCities].numberInhabitants =
                        Convert.ToUInt32(Console.ReadLine());
                    numCities++;
                    break;
                
                case 2:
                    for (int i = 0; i < numCities; i++)
                        Console.WriteLine("City {0}: {1} [ {2} ]",
                            i+1, cities[i].name,
                            cities[i].numberInhabitants);
                    break;
                    
                case 3:
                    Console.Write("Enter the number of city for modify: ");
                    int n = Convert.ToInt32( Console.ReadLine() ) - 1;
                    
                    Console.Write("Enter the new name of city {0}: ",
                        cities[n].name);
                    string newName = Console.ReadLine();
                    if (newName != "")
                        cities[n].name = newName;
                        
                    Console.Write
                        ("Enter the new numbers of inhabitants for {0}: ",
                            cities[n].name);
                    string newNumberString = Console.ReadLine();
                    if (newNumberString != "")
                    {
                        uint newNumber = Convert.ToUInt32(newNumberString);
                        cities[n].numberInhabitants = newNumber;
                    }
                    break;
                    
                case 4:
                    Console.Write("What do you want to search? ");
                    string parcialSearch = Console.ReadLine();
                    
                    for (int i = 0; i < numCities; i++)
                        if (cities[i].name.ToLower().
                                Contains(parcialSearch.ToLower()))
                            Console.WriteLine("City {0}: {1} [ {2} ]",
                                i+1, cities[i].name,
                                cities[i].numberInhabitants);
                    break;

                case 5:
                    if (numCities < SIZE - 1)
                    {
                        Console.Write("Specify the position: ");
                        int insertPosition = Convert.ToInt32(
                            Console.ReadLine()) - 1;
                        
                        for (int i = numCities; i > insertPosition; i--)
                        {
                            cities[i].name = cities[i-1].name;
                            cities[i].numberInhabitants = 
                                cities[i-1].numberInhabitants;
                        }
                        
                        Console.Write("Enter the name of city: ");
                        cities[insertPosition].name = Console.ReadLine();
                        
                        Console.Write(
                            "Enter the number of inhabitants of city: ");
                        cities[insertPosition].numberInhabitants =
                            Convert.ToUInt32(Console.ReadLine());
                        
                        numCities++;
                    }
                    else
                        Console.WriteLine("Database full.");
                    break;
                    
                case 6:
                    Console.Write("Enter the record to delete: ");
                    int deletePosition = Convert.ToInt32(Console.ReadLine())-1;
                    
                    for (int i = deletePosition; i < numCities - 1; i++)
                    {
                        cities[i].name = cities[i+1].name;
                        cities[i].numberInhabitants = 
                            cities[i+1].numberInhabitants;
                    }
                    numCities--;
                    break;
                    
                case 0:
                    Console.WriteLine("Bye!");
                    break;
            }
        }
        while(option != 0);
        
    }
}
