using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Journal theJournal = new Journal();
        Console.Write("What do you want to call your journal? (One Word Please) ");
        theJournal._journalTitle = Console.ReadLine();

        while (option != 5)
        {
            option = LoadMenu();
            if (option == 1)
            {
                Entry entry1 = new Entry();
                string prompt = LoadPrompts();
                entry1._promptSelected = prompt;
                Console.WriteLine($"{prompt} (Type Entry Below)");
                entry1._entryContent = Console.ReadLine();
                string date = GetDate();
                entry1._date = date;
                theJournal.AddEntry(entry1);
            }
            else if (option == 2)
            {
                theJournal.DisplayJournal();
            }
            else if (option == 3)
            {
                theJournal.SaveFile(theJournal._journalTitle);
            }
            else if (option == 4)
            {
                Console.Write("Please enter the name of the journal to load. ");
                theJournal._journalTitle = Console.ReadLine();
                theJournal.LoadFile(theJournal._journalTitle);
            }
            else if (option == 5)
            {
                Console.WriteLine("Journal Closed");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

    }

    static string LoadPrompts()
    {
        Prompts prompt1 = new Prompts();

        prompt1._prompts.Add("What are you grateful for?"); prompt1._prompts.Add("Write about a memorable moment from your childhood.");
        prompt1._prompts.Add("What made you smile today?"); prompt1._prompts.Add("Describe a challenge you overcame recently.");
        prompt1._prompts.Add("What are your goals for the next month?");
        prompt1._prompts.Add("Describe a person who has influenced your life.");
        prompt1._prompts.Add("What is your favorite hobby and why?");
        prompt1._prompts.Add("Write about a place you want to visit.");
        prompt1._prompts.Add("What is something new you learned recently?");
        prompt1._prompts.Add("Describe a perfect day for you.");

        string prompt = prompt1.PromptGenerator();
        return prompt;

    }

    static int LoadMenu()
    {

        Console.WriteLine("Please select from the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What option do you choose? ");
        int option = int.Parse(Console.ReadLine());
        return option;
    }

    static string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }


}

// write, save, load, quit, display