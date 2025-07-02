public class Video
{
    private string _title;
    private string _author;
    private int _length; // Length in seconds

    public comment(List<string> comments)
    {
        _comments = comments;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
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
    public string GetVideoInfo()
    {
        return $"{_title} by {_author}, Length: {_length} seconds";
    }
    public int numberofcomments()
    {
        return _comments.Count;
    }
}