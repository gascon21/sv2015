// Ruben Blanco
// Program: Complex Numbers

using System;

public class ComplexNumber
{
    protected double a;
    protected double b;
    
    public ComplexNumber(double n1, double n2)
    {
        a = n1;
        b = n2;
    }

    public void SetReal(double newReal)
    {
        a = newReal;
    }

    public double GetReal()
    {
        return a;
    }

    public void SetImag(double newImag)
    {
        b = newImag;
    }
    
    public double GetImag()
    {
        return b;
    }

    public override string ToString()
    {
        return "(" + a + "," + b + ")";
    }
    
    public double GetMagnitude()
    {
        return Math.Sqrt((a*a)+(b*b));
    }
    
    public void Add( ComplexNumber c2 )
    {
        this.a += c2.GetReal();
        this.b += c2.GetImag();
    }

    public static void Main()
    {
        ComplexNumber myNumber = 
            new ComplexNumber(2, 3);
        Console.WriteLine("Real: "+myNumber.GetReal());
        Console.WriteLine("Imag: "+myNumber.GetImag());
        
        myNumber.SetReal(-2);
        myNumber.SetImag(4.5);
        Console.WriteLine("Real: "+myNumber.GetReal());
        Console.WriteLine("Imag: "+myNumber.GetImag());
        
        Console.WriteLine(myNumber.ToString());
        
        ComplexNumber n2 = 
            new ComplexNumber(3, 4);
        Console.WriteLine(n2.ToString());
        Console.WriteLine("Magn: "+n2.GetMagnitude());
            
        myNumber.Add(n2);
        Console.WriteLine("Sum: {0}", 
            myNumber.ToString());
    }
}
