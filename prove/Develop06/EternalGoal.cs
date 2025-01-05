public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool Completed()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRep()
    {
        throw new NotImplementedException();
    }
}