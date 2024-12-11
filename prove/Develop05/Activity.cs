public class Activity
{
    private string _activityName;
    private string _description;
    protected int _timeAlloted;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }
    public void StartingMessage()
    {

        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine(_description + "\n");
        bool validInput = false;
        do
        {
            Console.WriteLine("How many seconds would you like to do this activity for? ");
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


    }
    public void EndingMessage()
    {

    }
    public void Spinner(int seconds)
    {

    }
    public void Countdown(int second)
    {

    }
}