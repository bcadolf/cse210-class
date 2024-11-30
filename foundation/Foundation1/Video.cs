using System.ComponentModel;
using System.Net;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    private int NumComments()
    {
        int num = _comments.Count();
        return num;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} {_length} Seconds");
        Console.WriteLine($"By: {_author} {NumComments()} comments");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetComment());
        }
    }

}