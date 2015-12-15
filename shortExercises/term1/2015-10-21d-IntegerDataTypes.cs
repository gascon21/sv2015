/*
 * Jose Manuel Mas 1DAM
 * 
 */
 
using System;
 
public class IntegerDTypes
{
    public static void Main()
    {
        byte age;
        ushort ybirth ;
        uint population;
        
        Console.Write("Enter age: ");
        age=Convert.ToByte(Console.ReadLine());
        
        Console.Write("Enter year of birth: ");
        ybirth=Convert.ToUInt16(Console.ReadLine());
        
        Console.Write("Enter population: ");
        population=Convert.ToUInt32(Console.ReadLine());
    }
}
