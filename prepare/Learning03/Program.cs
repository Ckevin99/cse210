using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Console.WriteLine(n1.GetDecimalValue());
        Console.WriteLine(n1.GetFractionalString());
        n1.SetTop(5);
        n1.SetBottom(2);
        Console.WriteLine(n1.GetFractionalString());
    
        Fraction n2 = new Fraction(5);
        Console.WriteLine(n2.GetDecimalValue());
        Console.WriteLine(n2.GetFractionalString());
        Console.WriteLine(n1.GetFractionalString());
        
        Fraction n3 = new Fraction(3,4);
        Console.WriteLine(n3.GetDecimalValue());
        Console.WriteLine(n3.GetFractionalString());
        
        Fraction n4 = new Fraction(1,3);
        Console.WriteLine(n4.GetDecimalValue());
        Console.WriteLine(n4.GetFractionalString());
        
        Console.WriteLine(n4.GetBottom());
        
        
    }
    
     
}