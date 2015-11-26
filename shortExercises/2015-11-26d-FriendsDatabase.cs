// David Gascón López
// Friends database

using System;
public class FriendsDatabase
{
    struct Friends
    {
        public string name;
        public ushort year;
    }
    
    public static void Main()
    {
        const int SIZE = 400;
        Friends[] person = new Friends[SIZE];
        int amount = 0;
        char opcion;
        
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
                    do
                    {
                        Console.Write ("Add a new name of friend {0}: ",
                                amount + 1);
                        person[amount].name = Console.ReadLine();

                        if (person[amount].name.Length > 40)
                            Console.WriteLine("40 letters max");
                    }
                    while (person[amount].name.Length > 40);
                    
                    do
                    {
                        Console.Write ("Add a birth year of friend {0}: ",
                                amount + 1);
                        person[amount].year = Convert.ToUInt16(
                                Console.ReadLine());
                        
                        if (person[amount].year < 1850 || person[amount].
                                year > 2100)
                            Console.WriteLine("Birth year must be between"
                                    + " 1850 and 2100");
                    }
                    while(person[amount].year < 1850 || person[amount].
                                year > 2100);
                    
                    Console.WriteLine();
                    
                    amount++;
                    break;
                
                case '2':
                    if (amount == 0)
                    {
                        Console.WriteLine("The data don't exist");
                    }
                    else
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            if(person[i].name.Length <= 30)
                                Console.WriteLine("{0}: {1} born in {2}", i+1,
                                        person[i].name, person[i].year);
                            else
                                Console.WriteLine("{0}: {1}... born in {2}",
                                        i+1, person[i].name.Substring(0, 30),
                                        person[i].year);
                                    
                            if (i % 20 == 19)
                            {
                                Console.WriteLine("Press Enter to countinue");
                                do
                                    key = Console.ReadKey();
                                while(key.Key != ConsoleKey.Enter);
                            }
                        }
                    }
                                
                    Console.WriteLine();
                    break;
            }
        }
        while(opcion != 'X');
        Console.WriteLine("Bye!");
    }
}
