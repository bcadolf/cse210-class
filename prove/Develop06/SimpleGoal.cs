public class SimpleGoal : Goal
{
    private bool _completed;
    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        _completed = false;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool Completed()
    {
        return _completed = true;
    }
    public override string GetStringRep()
    {
        throw new NotImplementedException();
    }

}