using System.Globalization;

public class Comment
{
    private string _username;
    private string _commentText;
    public Comment(string username, string text)
    {
        _username = username;
        _commentText = text;
    }

    public string GetComment()
    {
        string fullText = $"{_username}: {_commentText}";
        return fullText;
    }
}