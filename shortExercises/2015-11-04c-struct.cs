/* Jose Manuel Mas Ferrándiz
 * 
 */
using System;

public class structsStudent
{
	
	struct student
	{
		public string name;
		public byte age;
		public byte height;
		public char group;
		public float averageMark;
	}

    public static void Main()
    {
		student s1;
		
		s1.name = "Sergio";
		s1.age = 19;
		s1.height = 174;
		s1.group = 'A';
		s1.averageMark = 9.95f;
		
		Console.WriteLine("{0} has an average of {1}",
			s1.name, s1.averageMark);
    }
}
