public class ChecklistGoal : Goal
{
    private int _numCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _numCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool Completed()
    {
        throw new NotImplementedException();
    }
    public override string GetDetails()
    {
        return base.GetDetails();
    }
    public override string GetStringRep()
    {
        throw new NotImplementedException();
    }
}