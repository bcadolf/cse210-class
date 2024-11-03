using System;

class Program
{
    static void Main(string[] args)
    {
        // get the magic number and assign it as an intager to a variable NO LONGER USED NOW USE THE RANDOM NUMBER CODE LEFT TO SHOW ORINGAL STEPS
        // Console.Write("Choose your magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());

        // call a random number
        Random randomGen = new Random();
        int magicNum = randomGen.Next(1, 11);


        // ask the user to guess a number
        int guessNum;
        int attempts = 0;
        do
        {
            Console.Write("Guess the magic number: ");
            guessNum = int.Parse(Console.ReadLine());
            attempts++;
            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }

        } while (guessNum != magicNum);

        Console.WriteLine($"Correct the Magic Number was {magicNum}. You took {attempts} attempts.");
    }
}