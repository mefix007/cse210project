using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string Name, string Description, int duration)
    {
        _name = Name;
        _description = Description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string Name)
    {
        _name = Name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string Description)
    {
        _description = Description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of the activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGOod job! You've completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on {_name}.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i % animationStrings.Count]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in: {i} seconds ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void Start()
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }
    public abstract void Run();
}