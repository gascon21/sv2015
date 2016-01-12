// Class photo Album & Constructors

using System;

public class PhotoAlbum 
{
    protected int numberofPages = 0;    
    
    public PhotoAlbum()
    {
       numberofPages = 16;
       Console.WriteLine("Creating a PhotoAlbum");
    }    
       
    public PhotoAlbum(int n)
    {
       numberofPages = n;
       Console.WriteLine("Creating a PhotoAlbum " + n);
    } 
    
    public int GetNumberofPages()
    {
        return numberofPages;
    }    
     
}

// --------

public class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum()
    {
       numberofPages = 64;
       Console.WriteLine("Creating a BigPhotoAlbum");
    }
}

// --------

public class AlbumTest
{
    public static void Main()
    {
        PhotoAlbum p1 = new PhotoAlbum();
        Console.WriteLine(p1.GetNumberofPages());
        PhotoAlbum p2 = new PhotoAlbum(24);
        Console.WriteLine(p2.GetNumberofPages());
        BigPhotoAlbum p3 = new BigPhotoAlbum();
        Console.WriteLine(p3.GetNumberofPages());
    }    
}
