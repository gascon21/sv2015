/*
    Sacha Van de sijpe Bueno
    Program cities database

Create a database to store information about cities.

In a first approach, we will store only the name of each city and the 
number of inhabitants, and allocate space for up to 500 cities.

The menu should include the following options:

1 .- Add a new city (at the end of the existing data)
2 .- View all cities (name and inhabitants)
3 .- Modify a record (rename and / or change number of inhabitants)
4 .- Search in the records (display the ones which contain a certain 
     text in their name, whether in upper or lower case, using 
     partial search)
0 .- Exit

Note that option 3 (modify) must allow the user not to change the name 
or the number of inhabitants, if they press Enter instead of typing 
anything.
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
                    
                case 0:
                    Console.WriteLine("Bye!");
                    break;
            }
        }
        while(option != 0);
        
    }
}
