public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        StartingMessage();
        DisplayPrompt();
        DateTime duration = DateTime.Now.AddSeconds(_timeAlloted);
        while (DateTime.Now < duration)
        {
            DisplayQuestion();
        }
        EndingMessage();
    }
    private string GetRandom(List<string> list) // consolidated a random getter for the list and the prompts we do not need them different in this program. 
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        return list[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandom(_prompts));
        Spinner(5);
    }

    private void DisplayQuestion()
    {
        Console.WriteLine(GetRandom(_questions));
        int time;
        if (_timeAlloted < 30)
        {
            time = _timeAlloted;
        }
        else if (_timeAlloted < 60)
        {
            time = _timeAlloted / 2;
        }
        else
        {
            time = 30;
        }
        Spinner(time);
    }


}


