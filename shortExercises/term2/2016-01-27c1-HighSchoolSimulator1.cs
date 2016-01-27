// Ruben Blanco
// Program: HighSchoolSimulator

using System;

public class Person
{
    protected string name;
    protected int age;
    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public virtual void ShowStatus()
    {
        // TO DO:
        Console.WriteLine("Status of " + name);
    }

    public void Animate15Minutes()
    {
        // TO DO:
    }
}

// ----------------

public class Janitor: Person
{
    public Janitor(string name, int age)
        : base(name, age)
    {
    }
}

// ----------------

public class Teacher : Person
{
    public Teacher(string name, int age) 
        : base(name, age)
    {
    }
}


// ----------------

public class Pupil : Person
{
    protected int classNumber;

    public Pupil(string name, int age)
        : base(name, age)
    {
    }
    
    public Pupil(string name, int age, int classNumber) 
        : this(name, age)
    {
        this.classNumber = classNumber;
    }

    public void SetClassNumber(int classNumber)
    {
        this.classNumber = classNumber;
    }

    public int GetClassNumber()
    {
        return classNumber;
    }
    
    public override void ShowStatus()
    {
        // TO DO:
        Console.WriteLine("Status of " + name 
            + "in class" + classNumber);
    }
}


// ----------------

public class Classroom
{
    // TO DO: INTERACT WITH PERSONS
}

// ----------------

public class SchoolSimulator
{
    public static void Main()
    {
        Person [] myPerson = new Person [8];
        
        myPerson[0] = new Janitor("Juan", 40);
        myPerson[1] = new Teacher("Nacho", 38);
        myPerson[2] = new Teacher("Arturo", 30);
        myPerson[3] = new Pupil("Ruben", 30 ,1);
        myPerson[4] = new Pupil("Pedro", 28 ,2);
        myPerson[5] = new Pupil("Adrian", 25 ,2);
        myPerson[6] = new Pupil("David", 20 ,2);
        myPerson[7] = new Pupil("Chen", 26 ,1);
    }
}
