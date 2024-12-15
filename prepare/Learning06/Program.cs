using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle s1 = new Rectangle("red", 3, 2);
        Console.WriteLine(s1.GetArea());
        Console.WriteLine(s1.GetColor());

        Square s2 = new Square(3, "white");
        Console.WriteLine(s2.GetArea());
        Console.WriteLine(s2.GetColor());

        Circle s3 = new Circle(3, "blue");
        Console.WriteLine(s3.GetArea());
        Console.WriteLine(s3.GetColor());
    }
}