using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Ether", 12, 4);

        Scripture s1 = new Scripture(ref1, "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.");

        string done = "";
        do
        {
            Console.Clear();
            Console.WriteLine(s1.GetText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish:");
            done = Console.ReadLine();
            Console.Clear();
            s1.HideRandomWords(5);
            if (s1.AllHidden())
            {
                done = "quit";
            }
        } while (done != "quit");

        Console.WriteLine("Good job!");
    }
}