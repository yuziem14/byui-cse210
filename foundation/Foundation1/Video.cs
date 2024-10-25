public class Video {
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration) {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }

    public int GetTotalComments() {
        return _comments.Count();
    }

    public string Display() {
        return $"{_title} by {_author} | {DisplayDuration()} | {GetTotalComments()} comments";
    }

    public string DisplayComments() {
        string[] comments = _comments.Select(c => c.Display()).ToArray();
        return String.Join("\n", comments);
    }

    private string DisplayDuration() {
        int minutes = _duration / 60;
        int seconds = _duration % 60;
        return $"{minutes}m{seconds}s";
    }
}