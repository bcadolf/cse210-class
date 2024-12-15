public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }
    public void Run()
    {
        StartingMessage();
        DateTime duration = DateTime.Now.AddSeconds(_timeAlloted);
        while (DateTime.Now < duration)
        {
            Console.WriteLine("\n...Breath In...");
            Countdown(3);
            Console.WriteLine("\n...Breath Out...");
            Countdown(3);
        }
        EndingMessage();
    }
}