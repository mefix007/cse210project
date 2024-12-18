class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
        _iscomplete = _currentCount >= _targetCount;
    }
    public override void RecordEvent(ref int Score)
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Score += _points;

            if (_currentCount == _targetCount)
            {
                _iscomplete = true;
                Score += _bonusPoints;
                Console.WriteLine($"Goal '{_name}' completed! Bonus {_bonusPoints} points awarded!");
            }
            else
            {
                Console.WriteLine($"Recorded '{_name}'. You earned {_points} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed");
        }
    }
    public override string DisplayGoal()
    {
        return $"{(_iscomplete ? "[X]" : "[ ]")} {_name} ({_description}) -- completed {_currentCount}/{_targetCount}";
    }
    public override string SaveData()
    {
        return $"CheclistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}