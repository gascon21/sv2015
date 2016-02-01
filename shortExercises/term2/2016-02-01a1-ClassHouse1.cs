// Classes House, SmallApartment, Door, Person (1)

using System;

class HouseTest
{
    public static void Main()
    {
        SmallApartament myHouse = 
            new SmallApartament();
        Person myPerson = 
            new Person("Jose",myHouse);
        myPerson.ShowData();
    }
}


// -----------------------------

class House
{
    protected int area;
    protected Door myDoor;

    public House (int area)
    {
        this.area = area;
    }

    /*public House (Door myDoor)
    {
        area = 200;
        this.myDoor = myDoor;
    }*/

    public void SetArea(int area)
    {
        this.area = area;
    }

    public int GetArea()
    {
        return area;
    }

    public void ShowData()
    {
        Console.WriteLine("I am a house, my area is " +area+ " m2");
    }


    public Door GetDoor()
    {
        return myDoor;
    }
    
    public void SetDoor(Door d)
    {
        myDoor = d;
    }
    
}

// -----------------------------

class Door
{
    protected string color;

    public void ShowData()
    {
        Console.WriteLine("I am a door, my color is " + color);
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }
}

// -----------------------------

class SmallApartament : House
{
    /*public SmallApartament(Door door) : base (door)
    {
        area = 50;
    }*/
    
    public SmallApartament() : base (50)
    {
    }
    
}

// -----------------------------

class Person
{
    protected string name;
    protected House myHouse;

    public Person(string name, House house)
    {
        this.name = name;
        myHouse = house;
    }

    public void ShowData()
    {
        Console.WriteLine("Name: " + name);
        myHouse.ShowData();
        if (myHouse.GetDoor() != null)
            myHouse.GetDoor().ShowData();
        else
            Console.WriteLine("No data about the door");
    }
}
