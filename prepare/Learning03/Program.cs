using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.DisplayFraction());
        Console.WriteLine(frac1.DisplayDecimal());

        Fraction frac2 = new Fraction(4);
        Console.WriteLine(frac2.DisplayFraction());
        Console.WriteLine(frac2.DisplayDecimal());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.DisplayFraction());
        Console.WriteLine(frac3.DisplayDecimal());
    }
}