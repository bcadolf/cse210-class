public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    public Goal(string name, string desc, int points)
    {
        _description = desc;
        _goalName = name;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool Completed();
    public virtual string GetDetails()
    {
        return "";
    }
    public abstract string GetStringRep();

}