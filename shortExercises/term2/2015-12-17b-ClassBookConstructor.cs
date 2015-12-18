/* Create a class Book. It will have as attributes: Title, Author and pages 
 * Create getters and setters for those attributes.
 * Version 2: constructors */

class Book
{
    protected string author;
    protected string title;
    protected int pages;
    
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
    
    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public int GetPages()
    {
        return pages;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    public void SetPages(int newPages)
    {
        pages = newPages;
    }
}
