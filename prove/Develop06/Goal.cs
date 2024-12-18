using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _iscomplete;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _iscomplete = false;
    }
    public abstract void RecordEvent(ref int Score);
    public abstract string DisplayGoal();
    public abstract string SaveData();
    public bool IsComplete()
    {
        return _iscomplete;
    }
}