using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userName = PromptUserName();
        int userNum = PromptUserNum();

        int squaredNum = SquareNum(userNum);

        DisplayResult(userName, squaredNum);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNum()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNum(int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}