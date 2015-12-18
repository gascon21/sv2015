/* Create a class Book. It will have as attributes: Title, Author and pages 
 * Create getters and setters for those attributes.*/

class Book
{
    protected string author;
    protected string title;
    protected int pages;
    
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
