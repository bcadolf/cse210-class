using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What achievements are you proud of?",
        "When was a time you faced a significant challenge?",
        "What are your favorite activities to do with family?",
        "Who has been a positive influence in your life?",
        "What are your long-term goals and aspirations?",
        "How have you shown kindness to others recently?",
        "What are some things you are grateful for today?",
        "When have you felt a deep sense of peace or joy?"
    };


    public ListingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        StartingMessage();
        Console.WriteLine(GetRandomPrompt());
        Console.Write("Begin list in ");
        Countdown(10);
        _count = GetListFromUser().Count;
        Console.WriteLine($"You wrote {_count} items in your list.");
        EndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime duration = DateTime.Now.AddSeconds(_timeAlloted);
        while (DateTime.Now < duration)
        {
            Console.WriteLine("");
            string item = Console.ReadLine();
            items.Add(item);
        }
        return items;
    }
}