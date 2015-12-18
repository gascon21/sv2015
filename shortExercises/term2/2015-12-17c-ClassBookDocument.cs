/* Create a class Book. It will have as attributes: Title, Author and pages 
 * Create getters and setters for those attributes.
 * Version 3: Base class Document */

class Document
{
    protected string title;
    protected int pages;
        
    public string GetTitle()
    {
        return title;
    }

    public int GetPages()
    {
        return pages;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public void SetPages(int newPages)
    {
        pages = newPages;
    }
}


// ------------------------------------

class Book : Document
{
    protected string author;
        
    public Book()
    {
        author = "unknown";
        title = "unknown";
        pages = 0;
    }
    
    public Book( string newAuthor, string newTitle, int newPages )
    {
        author = newAuthor;
        title = newTitle;
        pages = newPages;
    }
    
    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

// ------------------------------------

class BooksDatabase
{
    public static void Main()
    {
        Book b = new Book();
        b.SetAuthor("Stephen King");
        b.SetTitle("It");
        
        System.Console.WriteLine("Book 1: {0} by {1}",
            b.GetTitle(),
            b.GetAuthor()
        );
    }
}
