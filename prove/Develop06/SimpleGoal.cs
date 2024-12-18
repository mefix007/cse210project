class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent(ref int Score)
    {
        if (!_iscomplete)
        {
            _iscomplete = true;
            Score += _points;
            Console.WriteLine($"Goal '{_name}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is alread completed.");
        }
    }
    public override string DisplayGoal()
    {
        return $"{(_iscomplete ? "[X]" : "[ ]")} {_name} ({_description})";
    }
    public override string SaveData()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_iscomplete}";
    }
}
