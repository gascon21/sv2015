// Media and derived classes
// Chen Chao
// 25-01-2016

using System;

public class Media
{
    protected string author;
    protected int sizeKB;
    protected string format;

    public Media(string author, int sizeKB, string format)
    {
        this.author = author;
        this.sizeKB = sizeKB;
        this.format = format;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetSize(int sizeKB)
    {
        this.sizeKB = sizeKB;
    }

    public int GetSize()
    {
        return sizeKB;
    }

    public void SetFormat(string format)
    {
        this.format = format;
    }

    public string GetFormat()
    {
        return format;
    }
}

// -----

public class Image : Media
{
    protected int width;
    protected int height;

    public Image(string author, int sizeKB, string format, int width, int height)
        : base(author, sizeKB, format)
    {
        this.width = width;
        this.height = height;
    }

    public void SetWidth(int width)
    {
        this.width = width;
    }

    public int GetWidth()
    {
        return width;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public int GetHeight()
    {
        return height;
    }
}

// -----

public class Sound : Media
{
    protected bool stereo;
    protected int kbps;
    protected int lengthSec;

    public Sound(string author, int sizeKB, string format, bool stereo,
            int kbps, int lengthSec) : base(author, sizeKB, format)
    {
        this.stereo = stereo;
        this.kbps = kbps;
        this.lengthSec = lengthSec;
    }

    public void SetStereo(bool stereo)
    {
        this.stereo = stereo;
    }

    public bool GetStereo()
    {
        return stereo;
    }

    public void SetKbps(int kbps)
    {
        this.kbps = kbps;
    }

    public int GetKbps()
    {
        return kbps;
    }

    public void SetLengthSec(int lengthSec)
    {
        this.lengthSec = lengthSec;
    }

    public int GetLengthSec()
    {
        return lengthSec;
    }
}

// -----

public class Video : Media
{
    protected string codec;
    protected int width;
    protected int height;
    protected int lengthSec;

    public Video(string author, int sizeKB, string format, string codec,
            int width, int height, int lengthSec) : base(author, sizeKB, format)
    {
        this.codec = codec;
        this.width = width;
        this.height = height;
        this.lengthSec = lengthSec;
    }

    public void SetCodec(string codec)
    {
        this.codec = codec;
    }

    public string GetCodec()
    {
        return codec;
    }

    public void SetWidth(int width)
    {
        this.width = width;
    }

    public int GetWidth()
    {
        return width;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public int GetHeight()
    {
        return height;
    }

    public void SetLengthSec(int lengthSec)
    {
        this.lengthSec = lengthSec;
    }

    public int GetLengthSec()
    {
        return lengthSec;
    }
}

// -----

public class MediaTest
{
    public static void Main()
    {
        Image image = new Image("chen", 123, "JPG", 1600, 1200);
        Sound sound = new Sound("chen", 123, "MP3", true, 128, 120);
        Video video = new Video("chen", 123, "MPEG4", "H.264", 1600, 1200, 360);

        Media[] media = new Media[4];

        for (byte i = 0; i < media.Length; i++)
            if (i % 2 == 0)
                media[i] = new Image("chen", 123, "JPG", 860, 640);
            else
                media[i] = new Sound("chen", 123, "MP3", false, 256, 240);

        Console.WriteLine("Image. Author: {0} sizeKb: {1} format: {2} width: {3} " +
            "height: {4}", image.GetAuthor(), image.GetSize(), image.GetFormat(),
            image.GetWidth(), image.GetHeight());
        Console.WriteLine("Sound. Author: {0} sizeKb: {1} format: {2} stereo: {3} " +
            "bkps: {4} length: {5}", sound.GetAuthor(), sound.GetSize(),
            sound.GetFormat(), sound.GetStereo(), sound.GetKbps(),
            sound.GetLengthSec());
        Console.WriteLine("Video. Author: {0} sizeKb: {1} format: {2} codec: {3} " +
            "width: {4} height: {5} length(sec): {6}", video.GetAuthor(),
            video.GetSize(), video.GetFormat(), video.GetCodec(),
            video.GetWidth(), video.GetHeight(), video.GetLengthSec());

        for (byte i = 0; i < media.Length; i++)
            Console.WriteLine("Media. Author: {0} format: {1} ",
                media[i].GetAuthor(),
                media[i].GetFormat());
    }
}
