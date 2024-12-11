public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base()
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeWorkList()
    {
        return $"Section {_textbookSection}, Problem {_problems}";
    }
}