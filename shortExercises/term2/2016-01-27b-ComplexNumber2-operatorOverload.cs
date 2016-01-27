// Complex Numbers (2)

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
        
    public static ComplexNumber Add(
        ComplexNumber c1, ComplexNumber c2)
    {
        ComplexNumber result = new ComplexNumber(
            c1.GetReal(), c1.GetImag());
        result.Add(c2);
        return result;
    }
    
    public static ComplexNumber operator +(
        ComplexNumber c1, ComplexNumber c2)
    {
        ComplexNumber result = new ComplexNumber(
            c1.GetReal(), c1.GetImag());
        result.Add(c2);
        return result;
    }
    
}

// =======================================================

class TestComplex
{
    public static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(2, -3);
        ComplexNumber c2 = new ComplexNumber(4, 6);
        
        Console.Write("{0} + {1} = ", c1, c2);
        c1.Add(c2);
        Console.WriteLine(c1.ToString());
        
        ComplexNumber c3 = ComplexNumber.Add(c2,c2);
        Console.WriteLine("c3 is " + c3.ToString());
        
        ComplexNumber c4 = c2 + c3;
        Console.WriteLine("c4 is " + c4.ToString());
    }
}
    
    
