public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string studentName, string topic, string title) : base()
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritinginformation()
    {
        return $"Title {_title}";
    }
}