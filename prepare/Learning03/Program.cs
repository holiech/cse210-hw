
using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();    
        Fraction fraction2 = new Fraction(5);       
        Fraction fraction3 = new Fraction(3, 4);    
        Fraction fraction4 = new Fraction(1, 3); 

        Console.WriteLine(fraction1.GetFractionString()); 
        Console.WriteLine(fraction2.GetTop());           
        Console.WriteLine(fraction3.GetFractionString()); 
        Console.WriteLine(fraction4.GetDecimalValue());   
    }
}
