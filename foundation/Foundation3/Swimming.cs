class Swimming : Activity
{
    private int _laps;
    private const double LapLengthkm = 50.0 / 1000;
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * LapLengthkm;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({Minutes} min) - Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per Km";
    }
}