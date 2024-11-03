using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNums = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num;
        do
        {
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());

            userNums.Add(num);

        } while (num != 0);

        int total = userNums.Sum();
        Console.WriteLine($"The sum total is {total}.");

        double avg = userNums.Average();
        Console.WriteLine($"The average is {avg}.");

        int largest = 0;
        foreach (int item in userNums)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        Console.WriteLine($"The largest number is {largest}.");

    }
}