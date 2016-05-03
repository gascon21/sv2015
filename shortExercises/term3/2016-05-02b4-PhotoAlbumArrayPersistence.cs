// Approaching persistence...
// Class photo Album & Array & Serialization

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

 [Serializable]
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

[Serializable]
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

    public static void Save(AlbumTest a)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("albums.dat",
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, a);
        stream.Close();
    }

    public static AlbumTest Load()
    {
        AlbumTest a;
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("albums.dat",
            FileMode.Open, FileAccess.Read, FileShare.Read);
        a = (AlbumTest) formatter.Deserialize(stream);
        stream.Close();
        return a;
    }

    public void SetPhotoAlbumAt(int pos, int size)
    {
        albums[pos] = new PhotoAlbum(size);
    }

    public static void Main()
    {
        AlbumTest a = new AlbumTest();
        a.Display();

        Save(a);
        a.SetPhotoAlbumAt(0, 123);
        a.Display();

        a = Load();
        a.Display();
    }
}
