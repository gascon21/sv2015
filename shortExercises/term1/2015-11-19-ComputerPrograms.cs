// Chen Chao, minor corrections by Nacho
// Program: Computer Programs
// 19-11-2015
// Note: this programa uses functions.
//       You will not be allowed to use functions in exam of topic 4

/*
Create a C # program that can store up to 1000 records of computer programs. For each program, you must keep the following data:

* Name
* Category
* Description
* Version (a set of data: version number -text-, 
  launch month -byte- and launch year -unsigned short-)

The program should allow the user the following operations:

1 - Add data of a new program (the name must not be empty, category 
    must not be more than 30 letters (or re-entered), and for the 
    description, it will accept only the first 100 letters entered and 
    skip the rest; the version needs no validation).

2 - Show the names of all the stored programs. Each name must appear on 
    one line. If there are more than 20 programs, you must pause after 
    displaying each block of 20 programs, and wait for the user to 
    press Enter before proceeding. The user should be notified if there 
    is no data.

3 - View all data for a certain program (from part of its name, 
    category or description, case sensitive). If there are several 
    programs that contain that text, the program will display all of 
    them, separated by a blank line. The user should be notified if 
    there are no matches found.

4 - Update a record (asking the user for the number, the program will 
    display the previous value of each field, and the user can press 
    Enter not to modify any of the data). He should be warned (but not 
    asked again) if he enters an incorrect record number. It is not 
    necessary to validate any of the fields.

5 - Delete a record, whose number will be indicated by the user. He 
    should be warned (but not asked again) if he enters an incorrect 
    number.

6 - Sort the data alphabetically by name.

7 - Fix redundant spaces (turn all the sequences of two or more spaces 
    into a single space, only in the name, for all existing records).

X - Exit the application (as we do not store the information, data will 
    be lost).
*/


using System;

public class ComputerPrograms
{
    struct Program
    {
        public string name;
        public string category;
        public string description;
        public Version version;
    }
    
    struct Version
    {
        public string number;
        public byte month;
        public ushort year;
    }
    
    const ushort SIZE = 1000;
    static Program[] prog = new Program[SIZE];
    static ushort records = 0;
    
    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Add new program.");
        Console.WriteLine("2. View all stored programs.");
        Console.WriteLine("3. View programs details.");
        Console.WriteLine("4. Update a record.");
        Console.WriteLine("5. Delete a record.");
        Console.WriteLine("6. Sort all records.");
        Console.WriteLine("7. Fix redundant spaces.");
        Console.WriteLine("X. Exit."); 
    }
    
    public static char GetOption()
    {
        return Console.ReadKey().KeyChar;
    }
    
    public static void PressKey()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadKey();
    }
    
    public static void AddProgram()
    {
        if (records < SIZE - 1)
        {
            Console.Write("Enter the name of the program {0}: ", 
                records + 1);
            do
            {
                prog[records].name = Console.ReadLine();
                
                if (prog[records].name == "")
                    Console.WriteLine("Name must not be empty.");
            }
            while (prog[records].name == "");
            
            const byte MAXCHARS = 30;
            Console.Write("Enter the category of the program {0}: ", 
                records + 1);
            do
            {
                prog[records].category = Console.ReadLine();
                
                if (prog[records].category.Length > MAXCHARS)
                    Console.WriteLine("The text must not occupy more than 30"+
                        " chars");
            }
            while (prog[records].category.Length > MAXCHARS);
            
            const byte MAXTEXT = 100;
            Console.Write("Enter the description of program {0}: ", records + 1);
            prog[records].description = Console.ReadLine();
            
            if (prog[records].description.Length > MAXTEXT)
                prog[records].description = prog[records].description
                    .Substring(0,MAXTEXT);
                
            Console.Write("Enter the version number of program {0}: ", records + 1);
            prog[records].version.number = Console.ReadLine();
            
            Console.Write("Enter the launch month of program {0}: ", records + 1);
            prog[records].version.month = Convert.ToByte(Console.ReadLine());
            
            Console.Write("Enter the launch year of program {0}: ",records + 1);
            prog[records].version.year = Convert.ToUInt16(Console.ReadLine());
            
            records++;
        }
        else
            Console.WriteLine("Database full.");
    }
    
    public static void ViewPrograms()
    {
        if (records > 0)
        {
            for (ushort i = 0; i < records; i++)
            {
                Console.WriteLine("Program name: {0}", prog[i].name);

                if (i % 20 == 19)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
        else
            Console.WriteLine("No programs stored.");
    }
    
    public static void SearchPrograms()
    {
        if (records > 0)
        {
            Console.Write("Enter the name of the program to find: ");
            string progToFind = Console.ReadLine().ToUpper();
            ushort progFound = 0;
            
            for (uint i = 0; i < records; i++)
            {
                if (prog[i].name.ToUpper().Contains(progToFind)
                    || prog[i].category.ToUpper().Contains(progToFind) 
                    || prog[i].description.ToUpper().Contains(progToFind))
                {
                    Console.WriteLine("Cod: {0} Name: {1} Category: {2} " +
                        "Descripion: {3} Version: {4} - {5}/{6}", i + 1,
                        prog[i].name, prog[i].category, prog[i].description,
                        prog[i].version.number, prog[i].version.month,
                        prog[i].version.year);
                    Console.WriteLine();
                    progFound++;
                }
            }
            
            if (progFound == 0)
                Console.WriteLine("No programs found!");
        }
        else
            Console.WriteLine("No programs stored.");
    }
    
    public static void UpdateRecord()
    {
        if (records > 0)
        {
            Console.Write("Enter the number of the program: ");
            int number = Convert.ToInt32(Console.ReadLine()) - 1;
            
            if (number < records)
            {
                Console.WriteLine("Name: {0}", prog[number].name);
                string newName = Console.ReadLine();
                if (newName != "")
                    prog[number].name = newName;
                    
                Console.WriteLine("Category: {0}", prog[number].category);
                string newCategory = Console.ReadLine();
                if (newCategory != "")
                    prog[number].category = newCategory;
                    
                Console.WriteLine("Descripion: {0}", prog[number].description);
                string newDescription = Console.ReadLine();
                if (newDescription != "")
                    prog[number].description = newDescription;
                
                Console.WriteLine("Version number: {0}", 
                    prog[number].version.number);
                string newVNumber = Console.ReadLine();
                if (newVNumber != "")
                    prog[number].version.number = newVNumber;
                
                Console.WriteLine("Version launch month: {0}", 
                    prog[number].version.month);
                string newMonth = Console.ReadLine();
                if (newMonth != "")
                    prog[number].version.month = Convert.ToByte(newMonth);
                
                Console.WriteLine("Version launch year: {0}", 
                    prog[number].version.year);
                string newYear = Console.ReadLine();
                if (newYear != "")
                    prog[number].version.year = Convert.ToUInt16(newYear);
            }
            else
                Console.WriteLine("Invalid number!");
        }
        else
            Console.WriteLine("No programs stored.");
    }
    
    public static void DeleteProgram()
    {
        if (records > 0)
        {
            Console.Write("Enter the number of the program to delete: ");
            int numDelete = Convert.ToInt32(Console.ReadLine()) - 1;
            
            for (int i = numDelete; i < records; i++)
                prog[i] = prog[i+1];
            records--;
            Console.WriteLine("Program deleted.");
        }
        else
            Console.WriteLine("No programs stored.");
    }
    
    public static void SortByName()
    {
        if (records > 0)
        {
            Program temp;
            
            for (int i = 0; i < records - 1; i++)
            {
                for (int j = i + 1; j < records; j++)
                {
                    if (prog[i].name.ToUpper().CompareTo(
                        prog[j].name.ToUpper()) >= 0)
                    {
                        temp = prog[i];
                        prog[i] = prog[j];
                        prog[j] = temp;
                    } 
                }
            }
            Console.WriteLine("All data sorted!");
        }
        else
            Console.WriteLine("No programs stored.");
    }
    
    public static void CorrectSpaces()
    {
        if (records > 0)
        {
            for (ushort i = 0; i < records; i++)
                while (prog[i].name.Contains("  "))
                    prog[i].name = prog[i].name.Replace("  "," ");
            
            Console.WriteLine("All extra spaces removed!");
        }
        else
            Console.WriteLine("No programs stored.");
    }
    
    public static void Main()
    {
        char option;
        
        do
        {
            DisplayMenu();
            option = GetOption();
            
            switch (option)
            {
                case '1':
                    Console.WriteLine();
                    AddProgram();
                    break;
                    
                case '2':
                    Console.WriteLine();
                    ViewPrograms();
                    PressKey();
                    break;
                    
                case '3':
                    Console.WriteLine();
                    SearchPrograms();
                    PressKey();
                    break;
                    
                case '4':
                    Console.WriteLine();
                    UpdateRecord();
                    PressKey();
                    break;
                    
                case '5':
                    Console.WriteLine();
                    DeleteProgram();
                    PressKey();
                    break;
                    
                case '6':
                    Console.WriteLine();
                    SortByName();
                    PressKey();
                    break;
                    
                case '7':
                    Console.WriteLine();
                    CorrectSpaces();
                    PressKey();
                    break;
                    
                case 'x':
                case 'X':
                    break;
                    
                default:
                    Console.WriteLine();
                    Console.WriteLine("Unknown option.");
                    PressKey();
                    break;
            }
        }
        while (option != 'x' && option != 'X');
        Console.WriteLine();
        Console.WriteLine("Bye!");
    }
}
