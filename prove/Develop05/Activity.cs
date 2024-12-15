public class Activity
{
    private string _activityName;
    private string _description;
    protected int _timeAlloted;

    protected Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }
    protected void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine(_description + "\n");
        bool validInput = false;
        do
        {
            Console.Write("How many seconds would you like to do this activity for? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int time))
            {
                _timeAlloted = time;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer of seconds");
            }
        } while (!validInput);
        Console.Clear();
        Console.WriteLine("Prepare to Begin.");
        Spinner(4);


    }
    protected void EndingMessage()
    {
        Console.WriteLine("Good job finishing the activity.");
        Spinner(5);
        Console.Write($"You did the {_activityName} for {_timeAlloted} seconds.\nReturning to menu in ");
        Countdown(3);
    }
    protected void Spinner(int seconds)
    {
        DateTime end = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < end)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }
    protected void Countdown(int second)
    {
        int count = 0;
        do
        {
            Console.Write($" ~{second - count}~");
            count += 1;
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b\b");
        } while (count < second);
    }
}