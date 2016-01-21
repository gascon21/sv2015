// Chen Chao
// 20-01-2016

using System;

public class Table
{
    protected int width;
    protected int height;
    
    public Table(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    
    public virtual void ShowData()
    {
        Console.WriteLine("The width is: {0} and the height is: {1}", width,
            height);
    }
}

public class CoffeeTable : Table
{
    public CoffeeTable(int width, int height) 
        : base(width, height)
    {
    }
        
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine("Coffe table");
    }
}

public class TestTable
{
    public static void Main()
    {
        Table[] table = new Table[10];
        Random r = new Random();
        
        for (int i = 0; i < table.Length; i++)
        {
            int newWidth;
            int newHeight;
            
            if (i < 5)
            {
                newWidth = r.Next(50,201);
                newHeight = r.Next(50,201);
                table[i] = new Table(newWidth, newHeight);
            }
            else
            {
                newWidth = r.Next(40,121);
                newHeight = r.Next(40,121);
                table[i] = new CoffeeTable(newWidth, newHeight);
            }
        }
        
        for (int i = 0; i < table.Length; i++)
            table[i].ShowData();
    }
}
