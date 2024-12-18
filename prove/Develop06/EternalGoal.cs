class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent(ref int Score)
    {
        Score += _points;
        Console.WriteLine($"Recorded '{_name}'. You earned {_points} points");
    }
    public override string DisplayGoal()
    {
        return $"[ETERNAL] {_name} ({_description})";
    }
    public override string SaveData()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}