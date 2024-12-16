public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string studentName, string topic, string Title) : base()
    {
        _studentName = studentName;
        _topic = topic;
        _title = Title;
    }
    public string GetTilte()
    {
        return _title;
    }
    public void SetTitle(string Title)
    {
        _title = Title;
    }
    public string GetWritinginformation()
    {
        return $"Title {_title}";
    }
}