/*
Create a C# program that can store up to 500 records of classical 
computers. For each computer, you must keep the following data:

• Brand Name (e.g. Amstrad)
• Model (e.g. CPC664)
• Year (e.g. 1984)
• RAM (set of 2 data: the measure unit, e.g. Kb, and size, e.g. 64)
• Comments

The program should allow the user the following operations:

1 - Add a new computer data (the brand must not be empty, the model 
    should not occupy more than 50 letters, and if so, it must be entered 
    again, if the year is before 1900, it should be stored as 0, to 
    indicate that it is not valid).

2 - Show all brands and models of computers stored. Each computer 
    (brand and model) should appear on one line, separated by a hyphen 
    (eg "Amstrad - CPC664"). The program should pause after displaying 
    each block of 24 computers, display the message "Press Enter to 
    continue" and wait until the user presses Enter. The user should be 
    notified if there is no data.

3 - Search for computers that contain a certain text (as part of its 
    brand, model or comments, case insensitive). If the year is 0, it 
    should display: "Year: unknown." Data must be displayed on separate 
    lines. If multiple computers containing that text are found, all of 
    them will be shown, separated by a blank line. The user should be 
    notified if none is found.

4 - Update a record (it will ask for the number, will display the 
    previous value of each field and the user can press Enter not to 
    modify any of the data). The user should be warned (but not asked 
    again) if he enters an incorrect record number. It is not necessary 
    to validate any of the fields.

5 - Delete some data, in the position indicated by the user. The user 
    should be warned (but not asked again) if he enters an incorrect 
    record number.

6 - Insert data in a position chosen by the user (by moving the rest of 
    the records to the right). The user should be warned (but not asked 
    again) if he enters an incorrect record number.

7 - Sort the data alphabetically by brand+model.

8 - Remove extra spaces (initial and final spaces in all the data: turn 
    comments like " Test Data " into "test data".

Q - Quit (end the application; as we do not store the information, will 
    be lost).
*/

using System;

public class ComputersDatabase
{
    struct RAM
    {
        public string unit;
        public float size;
        
    }
    
    struct computer
    {
        public string brand;
        public string model;
        public string comment;
        public int year;
        public RAM memory;
        
    }

    public static void Main ()
    {
        const int SIZE = 500;
        computer[] computers = new computer[SIZE];
        int amount = 0;;
        char option;
        bool  finished = false;
        Console.WriteLine("Welcome to the official computers database");
        do{
            Console.WriteLine("1.Add a new computer");
            Console.WriteLine("2.View all computers");
            Console.WriteLine("3.Search a computer");
            Console.WriteLine("4.Update a computer");
            Console.WriteLine("5.Delete a computer");
            Console.WriteLine("6.insert a computer in a certain position");
            Console.WriteLine("7.Sort computers alphabetically");
            Console.WriteLine("8.remove extra spaces");
            Console.WriteLine("Q.Quit");
            option=Convert.ToChar(Console.ReadLine());
            
            switch(option)
            {
                case '1':
                    if(amount <=SIZE)
                    {
                        Console.WriteLine("Enter the brand:");
                        do
                        {
                            computers[amount].brand =  Console.ReadLine();
                            if(computers[amount].brand == "")
                                Console.WriteLine("Invalid brand. Enter a valid One");
                        } while(computers[amount].brand =="");
                        
                        Console.WriteLine("Enter the name of the model");
                        do 
                        {
                            computers[amount].model = Console.ReadLine();
                            if(computers[amount].model.Length > 50)
                                Console.WriteLine("Too long name, insert the model again:");
                        } while (computers[amount].model.Length > 50);
                        
                        Console.WriteLine("Enter the year");
                        computers[amount].year = Convert.ToInt32(Console.ReadLine());
                        if(computers[amount].year < 1900)
                            computers[amount].year = 0;
                        
                        Console.WriteLine("Enter the RAM unit (e.g. Kb)");
                        computers[amount].memory.unit = Console.ReadLine();
                        
                        Console.WriteLine("Enter the RAM size (e.g. 64)");
                        computers[amount].memory.size = Convert.ToSingle(Console.ReadLine());
                        
                        Console.WriteLine("Enter the comment");
                        computers[amount].comment = Convert.ToString(Console.ReadLine());
                        
                        amount++;
                    }
                    else 
                        Console.WriteLine("Invalid operation; Full database");
                    break;
                
                case '2':
                    if(amount==0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        int cont = 0;
                        do
                        {
                            Console.Write("Computer {0}:",cont+1);
                            Console.Write("{0}",computers[cont].brand);
                            Console.Write(" - {0}",computers[cont].model);
                            Console.WriteLine();
                            cont++;
                            if(cont % 24 == 0)
                                Console.WriteLine("Press Enter to continue");                            
                        } while (cont < amount);
                    }
                    Console.WriteLine();
                    break;
                
                case '3':
                    Console.WriteLine("Enter the text you want to search for: ");
                    string search = Console.ReadLine().ToUpper();
                    bool found = false;
                    for(int k = 0;k < amount; k++){
                        if(computers[k].brand.ToUpper().Contains(search)
                            || computers[k].model.ToUpper().Contains(search)
                            || computers[k].comment.ToUpper().Contains(search))
                        {
                            found = true;
                            Console.WriteLine("Computers found");
                            Console.Write("Brand: {0}",computers[k].brand);
                            Console.WriteLine("Model: {0}",computers[k].model);
                            if(computers[k].year == 0)
                                Console.WriteLine("Unknown year");
                            else
                                Console.Write("Year: {0}",computers[k].year);
                            Console.Write("RAM: " + computers[k].memory.size +
                                " " + computers[k].memory.unit);
                            Console.Write("Comment: {0}",computers[k].comment);
                            }
                    }
                    if(!found)
                        Console.WriteLine("No computers found");
                    Console.WriteLine();
                    break;
                
                case '4':
                    if(amount == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        Console.WriteLine("Enter the position to update: ");
                        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                        if(pos > amount-1 || pos <0)
                            Console.WriteLine("Invalid position");
                        else
                        {
                            string text;
                            Console.WriteLine("Computer number {0}",pos+1);
                            Console.Write("Brand ({0}): ",computers[pos].brand);
                            text = Console.ReadLine();
                            if (text != "")
                                computers[pos].brand = text;
                                
                            Console.Write("Model ({0}): ",computers[pos].model);
                            text = Console.ReadLine();
                            if (text != "")
                                computers[pos].model = text;
                                
                            Console.WriteLine("Year ({0}): ",computers[pos].year);
                            text = Console.ReadLine();
                            if (text != "")
                                computers[pos].year = Convert.ToInt32(text);
                                
                            Console.WriteLine("RAM size: {0}",computers[pos].memory.size);
                            text = Console.ReadLine();
                            if (text != "")
                                computers[pos].memory.size = Convert.ToInt32(text);
                                
                            Console.WriteLine("RAM unit: {0}",computers[pos].memory.unit);
                            text = Console.ReadLine();
                            if (text != "")
                                computers[pos].memory.unit = text;
                            
                            Console.WriteLine("Comment: {0}",computers[pos].comment);
                            text = Console.ReadLine();
                            if (text != "")
                                computers[pos].comment = text;

                        }
                    }
                    Console.WriteLine();
                    break;
                
                case '5':
                    if(amount == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        Console.WriteLine("Select the position of the computer to delete: ");
                        int pos = Convert.ToInt32(Console.ReadLine())-1;
                        if(pos > amount-1 || pos < 0)
                            Console.WriteLine("Invalid position");
                        else
                        {
                            for(int j = pos; j < amount-1; j++)
                                computers[j] = computers[j+1];
                            amount--;
                        }
                    }
                    Console.WriteLine();
                    break;
                    
                case '6':
                    if(amount == 0)
                        Console.WriteLine("No computers available yet");
                    else
                    {
                        Console.WriteLine("Enter the position to insert a new computer: ");
                        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                        if(pos > amount || pos < 0)
                            Console.WriteLine("Invalid position");
                        else
                        {
                            amount++;
                            for(int i= amount; i >= pos; i--)
                                computers[i] = computers[i-1];
                            Console.WriteLine("Enter the brand:");
                            do{
                                computers[pos].brand = Console.ReadLine();
                                if(computers[pos].brand == ""){
                                    Console.WriteLine("Invalid brand. Enter a valid One");
                                }
                            } while(computers[pos].brand =="");
                        
                            Console.WriteLine("Enter the name of the model");
                            do {
                                computers[pos].model = Console.ReadLine();
                                if(computers[pos].model.Length > 50){
                                Console.WriteLine("Too long name, insert the model again:");
                                }
                            }while (computers[pos].model.Length > 50);
                        
                            Console.WriteLine("Enter the year");
                            computers[pos].year = Convert.ToInt32(Console.ReadLine());
                            if(computers[pos].year < 1900){
                                computers[pos].year = 0;
                            }
                            
                            Console.WriteLine("Enter the RAM unit (e.g. Kb)");
                            computers[pos].memory.unit = Console.ReadLine();
                            
                            Console.WriteLine("Enter the RAM size (e.g. 64)");
                            computers[pos].memory.size = Convert.ToSingle(Console.ReadLine());
                        
                            Console.WriteLine("Enter the comment");
                            computers[pos].comment = Console.ReadLine();
                        }
                    }                
                    Console.WriteLine();
                    break;

                case '7':
                    computer temp;
                    for (uint i= 0; i<amount-1; i++)
                    {
                        for (uint j= i+1; j<amount; j++)
                        {
                            string data1 = computers[i].brand + computers[i].model;
                            string data2 = computers[j].brand + computers[j].model;
                            if ( data1.CompareTo(data2) > 0 )
                            {
                                temp = computers[i];
                                computers[i] = computers[j];
                                computers[j] = temp;
                            }
                        }
                    }                
                    Console.WriteLine("Data sorted");
                    Console.WriteLine();
                    break;
                
                case '8':
                    for(int i = 0; i < amount; i++)
                        computers[i].comment = computers[i].comment.Trim();
                    Console.WriteLine("Spaces trimmed");
                    Console.WriteLine();
                    break;
                    
                case 'q':
                case 'Q':
                    finished = true;
                    Console.WriteLine("Thanks for using our services, have a nice day!");
                    break;

                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }while ( ! finished );
    }
}

