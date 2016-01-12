// Class photo Album & Array

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

public class AlbumTest
{
    public static void Main()
    {
        PhotoAlbum[] albums = new PhotoAlbum[3];
        
        albums[0] = new PhotoAlbum();
        albums[1] = new PhotoAlbum(24);
        albums[2] = new PhotoAlbum(40);
        
        for(int i=0; i < 3; i++)
        {
            Console.WriteLine("Album {0} has {1} pages",
                i+1, albums[i].GetNumberofPages());
        }
    }    
}
