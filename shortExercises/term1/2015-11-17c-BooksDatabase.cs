// Mónica Esteve Fernández
// Books database

// Note: this version uses functions
// In the exam of Topic 4 you will not be allowed to use functions

using System;
public class Booksdatabase
{
    struct book
    {
        public string title;
        public string author;
        public string location;
    }
    
    const int SIZE = 1000000;
    static book [] texts = new book[SIZE];
    static uint nElement = 0;
    
    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1.-Add data for one book");
        Console.WriteLine("2.-Display all the entered books");
        Console.WriteLine("3.-Search for the book by title");
        Console.WriteLine("4.-Delete a book at a known position");
        Console.WriteLine("5.-Sort by title");
        Console.WriteLine("6.-Find duplicates by title and author");
        Console.WriteLine("0.-Exit");
    }
    
    public static char GetOption()
    {
        Console.WriteLine("Choose an option: ");
        return Console.ReadKey().KeyChar;
    }
    
    public static void PressKey()
    {
        // stop console
        char stop;
        Console.Write("Press key...");
        stop = Console.ReadKey().KeyChar;
    }
    
    public static void AddBooks()
    {
        Console.WriteLine("Enter title:");
        texts[nElement].title=Console.ReadLine();
        Console.WriteLine("Enter author:");
        texts[nElement].author=Console.ReadLine();
        Console.WriteLine("Enter location:");
        texts[nElement].location=Console.ReadLine();
        nElement++;
    }
    
    public static void ViewBooks()
    {
        for (uint i=0; i<nElement;i++)
        {
          if (i%20==19)
            Console.ReadLine();
        else
            Console.WriteLine(
                "Title: {0} | Author: {1}",
                texts[i].title,
                texts[i].author);
        }
    }
    
    public static void SearchBook()
    {
        string booksearch="";
        Console.Write("Enter the title to search: ");
        booksearch = Console.ReadLine().ToLower();
    
        for (uint i=0; i<nElement;i++)
            if ( texts[i].title.ToLower() == booksearch)
                Console.WriteLine(
                "Title: {0} | Author: {1} | Loc.: {2}",
                texts[i].title,
                texts[i].author,
                texts[i].location);
    }
    
    public static void DeleteByTitle()
    {
        uint nitem;
        
        Console.Write("Delete a book. Which one?: ");
        nitem = Convert.ToUInt32(Console.ReadLine()) - 1;
        for (uint i= nitem; i < nElement-1; i++)
        {
            texts[i].title= texts[i+1].title;
            texts[i].author= texts[i+1].author;
            texts[i].location= texts[i+1].location;
        }
        nElement--;    
                   
    }
    
    public static void SortByTitle()
    {
        book exchange;
        for (uint i= 0; i<nElement-1; i++)
        {
            for (uint j= i+1; j<nElement; j++)
            {
                if ( String.Compare(texts[i].title, texts[j].title,true)>=0)
                {
                    exchange = texts[i];
                    texts[i] = texts[j];
                    texts[j] = exchange;
                }
            }
        }

    }
    
    public static void FindDuplicates()
    {
        for (uint i= 0; i<nElement-1; i++)
            for (uint j= 1; j<nElement; j++)
                if( texts[i].title.ToLower() == texts[j].title.ToLower() &&
                        texts[i].author.ToLower() == texts[j].author.ToLower() )
                    Console.WriteLine(
                        "Title: {0} | Author: {1} | Loc.: {2}",
                        texts[i].title,
                        texts[i].author,
                        texts[i].location);
    }
    
    
    public static void Main()
    {
        DisplayMenu();
        char option;
        
        do
        {
            DisplayMenu();
            option = GetOption();
            
            switch (option)
            {
                case '0':
                    break;
                    
                case '1':
                    Console.WriteLine();
                    AddBooks();
                    break;
                    
                case '2':
                    Console.WriteLine();
                    ViewBooks();
                    PressKey();
                    break;
                    
                case '3':
                    Console.WriteLine();
                    SearchBook();
                    PressKey();
                    break;
                    
                case '4':
                    DeleteByTitle();
                    PressKey();
                    break;
                    
                case '5':
                    SortByTitle();
 
                    PressKey();
                    break;
                    
                case '6':
                    FindDuplicates();
                    PressKey();
                    break;
                default:
                    Console.WriteLine("Unknown option");
                    break;
            }
        }
        while(option != '0');
    }
}
