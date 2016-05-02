// Approaching persistence...
// Class photo Album & Array & File

using System;
using System.IO;

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
    PhotoAlbum[] albums;

    public AlbumTest()
    {
        albums = new PhotoAlbum[3];
        albums[0] = new PhotoAlbum();
        albums[1] = new PhotoAlbum(24);
        albums[2] = new PhotoAlbum(40);
    }

    public void Display()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Album {0} has {1} pages",
                i + 1, albums[i].GetNumberofPages());
        }
    }

    public void Save()
    {
        BinaryWriter file = new BinaryWriter(
            File.Open("albums.dat", FileMode.Create));
        for (int i = 0; i < albums.Length; i++)
        {
            file.Write(albums[i].GetNumberofPages());
        }
        file.Close();
    }

    public void Load()
    {
        BinaryReader file = new BinaryReader(
            File.Open("albums.dat", FileMode.Open));
        for (int i = 0; i < albums.Length; i++)
        {
            albums[i] = new PhotoAlbum(  file.ReadInt32());
        }
        file.Close();
    }

    public void SetPhotoAlbumAt(int pos, int size)
    {
        albums[pos] = new PhotoAlbum(size);
    }

    public static void Main()
    {
        AlbumTest a = new AlbumTest();
        a.Display();

        a.Save();
        a.SetPhotoAlbumAt(0, 123);
        a.Display();

        a.Load();
        a.Display();
    }
}
