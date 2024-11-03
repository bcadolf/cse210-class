using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        string gradeLetter;
        int gradeNum = int.Parse(grade);
        bool pass = true;
        if (gradeNum >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNum >= 80 && gradeNum < 90)
        {
            gradeLetter = "B";
        }
        else if (gradeNum >= 70 && gradeNum < 80)
        {
            gradeLetter = "C";
        }
        else if (gradeNum >= 60 && gradeNum < 70)
        {
            gradeLetter = "D";
            pass = false;
        }
        else
        {
            gradeLetter = "F";
            pass = false;
        }

        Console.Write($"Your score is {gradeLetter}. ");
        if (pass)
        {
            Console.WriteLine("Congrats you passed!!!!");
        }
        else if (!pass)
        {
            Console.WriteLine("You did not pass please study further.");
        }
    }
}