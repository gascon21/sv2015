// Class photo Album & big photo album & Array

using System;

public class PhotoAlbum
{
    protected int numberofPages = 0;

    public PhotoAlbum() : this(16)
    {
    }

    public PhotoAlbum(int numberofPages)
    {
       this.numberofPages = numberofPages;
    }

    public int GetNumberofPages()
    {
        return numberofPages;
    }

    public virtual void DisplayNumberOfPages()
    {
        Console.WriteLine("I am a PhotoAlbum with {0} pages",
                numberofPages);
    }
}

// --------

public class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum()
    {
       numberofPages = 64;
    }
    
    public override void DisplayNumberOfPages()
    {
        Console.WriteLine("I am a BigPhotoAlbum with {0} pages",
                numberofPages);
    }
}

// --------

public class AlbumTest
{
    public static void Main()
    {
        PhotoAlbum[] albums = new PhotoAlbum[10];

        for(int i=0; i < 3; i++)
            albums[i] = new PhotoAlbum();
        for(int i=3; i < 5; i++)
            albums[i] = new PhotoAlbum(24);
        for(int i=5; i < 10; i++)
            albums[i] = new BigPhotoAlbum();

        for(int i=0; i < 10; i++)
            albums[i].DisplayNumberOfPages();
    }
}
