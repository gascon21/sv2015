// Miguel Moya Ortega
// Array of structs

using System;

public class Structs
{
    struct student
    {
        public string name;
        public byte age;
        public byte height;
        public float mark;
        public char group;
    }
    
    public static void Main()
    {
        const int SIZE = 3;
        
        student[] s = new student[SIZE];
        
        s[0].name = "Miguel";
        s[0].age = 20;
        s[0].height = 179;
        s[0].group = 'D';
        s[0].mark = 99.543f;
        
        s[1].name = "Sergio";
        s[1].age = 19;
        s[1].height = 105;
        s[1].group = 'D';
        s[1].mark = -10f;
        
        s[2].name = "Chen";
        s[2].age = 21;
        s[2].height = 252;
        s[2].group = 'D';
        s[2].mark = 9.546534f;
        
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine (s[i].name);
            Console.WriteLine (s[i].age);
            Console.WriteLine (s[i].height);
            Console.WriteLine (s[i].group);
            Console.WriteLine (s[i].mark);
            Console.WriteLine ();
        }
    }
}
