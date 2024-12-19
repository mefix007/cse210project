using System;
using System.Collections.Generic;
abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime Date
    {
        get { return _date; }
    }
    public int Minutes
    {
        get { return _minutes; }
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date:dd MM yyyy} ({_minutes} min): Distance {GetDistance():0.0}, speed {GetSpeed():0.0}, Pace {GetPace():0.0}";
    }
}