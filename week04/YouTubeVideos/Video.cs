using System.Configuration.Assemblies;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public string DisplayVideo()
    {
        return $"{_title} by {_author}, Duration: {_length} seconds";
    }
}