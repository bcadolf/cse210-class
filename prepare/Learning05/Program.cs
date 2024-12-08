using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Chapter 5: Algebraic Expressions", "Problems 1-10, 15, 18, 22", "Emily Johnson", "Algebra");

        Console.WriteLine("Math Assignment:");
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Impact of Climate Change", "James Smith", "Environmental Science");

        Console.WriteLine("\nWriting Assignment:");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine($"Title: {writingAssignment.GetTitle()}"); // You'll need to add a GetTitle method


    }
}