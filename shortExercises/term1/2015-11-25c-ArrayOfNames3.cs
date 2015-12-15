/* Sergio Martínez Mira
 * Array of Names
 * */

using System;

public class ArrayofNames
{
    public static void Main()
    {

        const int SIZE = 50;
        string[] name = new string[SIZE];
        byte option;
        int amount = 0;
        
        do
        {
            Console.WriteLine("1.- Add a new name.");
            Console.WriteLine("2.- Show all data.");
            Console.WriteLine("3.- Delete a name.");
            Console.WriteLine("4.- Insert a name in a certain position.");
            Console.WriteLine("5.- Exchange two names.");
            Console.WriteLine
                ("6.- Search for names containing a certain text.");
            Console.WriteLine("0.- Exit.");
            
            option = Convert.ToByte(Console.ReadLine());
            switch (option)
            {
                case 0:
                    break;
                    
                case 1:
                    Console.Write("Enter the name title of the book: ");
                    name[amount] = Console.ReadLine();
                    amount++;
                    break;
                    
                case 2:
                    for (int i = 0; i < amount; i++)
                    {
                        Console.WriteLine("{0}: {1}", i+1, name[i]);
                    }
                    break;
                    
                case 3:
                    Console.Write("Enter the position to delete: ");
                    int deleteposition = Convert.ToInt32(Console.ReadLine());
                    deleteposition--;
                    
                    if ((deleteposition >= amount) || (deleteposition < 0))
                    {
                        Console.WriteLine("You can't do that");
                    }
                    else
                    {
                        for (int i = deleteposition; i < amount; i++)
                            name[i] = name[i+1];
                        
                        amount--;
                    }
                    break;
                    
                case 4:                    
                    Console.Write("Enter position to insert the new name: ");
                    int insertposition = Convert.ToInt32(Console.ReadLine());
                    insertposition--;
                    
                    if ((insertposition > amount) || (insertposition < 0))
                    {
                        Console.WriteLine("You can't do that");
                        break;
                    }
                    amount++;
                    
                    for (int i = amount; i > insertposition; i--)
                        name[i] = name [i-1];
                        
                    Console.Write("Enter the name title of the book: ");
                    name[insertposition] = Console.ReadLine();
                    break;
                    
                    
                case 5:
                    Console.Write("Enter position A to change: ");
                    int posA = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter position B to change: ");
                    int posB = Convert.ToInt32(Console.ReadLine());
                    posA--;
                    posB--;
                    
                    if ((posA < 0) || (posA >= amount)
                            || (posB < 0) || (posB >= amount))
                        Console.WriteLine("Out of range!");
                    else
                    {
                        string temp;
                        
                        temp = name[posA];
                        name[posA] = name[posB];
                        name[posB] = temp;
                    }
                    
                    break;
                
                case 6:
                    Console.Write("Enter text to search in names: ");
                    string text = Console.ReadLine().ToUpper();
                    
                    bool found = false;
                    for (int i = 0; i < amount; i++)
                        if (name[i].ToUpper().Contains(text))
                        {
                            Console.WriteLine(name[i]);
                            found = true;
                        }
                    if (! found)
                        Console.WriteLine("Not found!");
                    break;
            }
        }
        while (option != 0);

    }
}
