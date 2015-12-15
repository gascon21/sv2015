// Ruben Blanco
// Program: NestedStructs

/*
Create a struct to store two data for a person: name and date of birth. 
The date of birth must be another struct consisting on day, month and 
year. Finally, create an array of persons, ask the user for the data of 
two persons and display them.
*/

using System;

public class NestedStructs
{
    struct date
    {
        public byte day;
        public byte month;
        public int year;
    }
    
    struct person
    {
        public string name;
        public string surname;
        public date birthDate;
    }

    public static void Main()
    {
        const int SIZE = 2;
        person [] data = new person [SIZE];
        
        for(int i=0;i<SIZE;i++)
        {
            Console.Write("Enter name {0}: ", i+1);
            data[i].name = Console.ReadLine();
            
            Console.Write("Enter surname {0}: ", i+1);
            data[i].surname = Console.ReadLine();
            
            Console.Write("Enter birth day {0}: ", i+1);
            data[i].birthDate.day = Convert.ToByte(Console.ReadLine());
            
            Console.Write("Enter birth month {0}: ", i+1);
            data[i].birthDate.month = Convert.ToByte(Console.ReadLine());
            
            Console.Write("Enter birth year {0}: ", i+1);
            data[i].birthDate.year = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
        }
        
        for(int i=0;i<SIZE;i++)
        {
        Console.WriteLine("{0} {1} birth date is: {2}-{3}-{4}", data[i].name,
            data[i].surname, data[i].birthDate.day, data[i].birthDate.month,
            data[i].birthDate.year);
        }
        Console.WriteLine();
    }
}
        
