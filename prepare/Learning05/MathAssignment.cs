using System.Security.Cryptography.X509Certificates;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string book, string problem, string name, string topic) : base(name, topic)
    {
        _textbookSection = book;
        _problems = problem;
    }

    public string GetHomeWorkList()
    {
        string hw = $"{GetSummary()}\nStudy: {_textbookSection}\nSolve: {_problems}";
        return hw;
    }
}