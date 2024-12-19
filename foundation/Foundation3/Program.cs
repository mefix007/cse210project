using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        {
            activities.Add(new Running(new DateTime(2022, 11, 3), 40, 5.0));
            activities.Add(new Cycling(new DateTime(2022, 11, 3), 50, 15.0));
            activities.Add(new Swimming(new DateTime(2022, 11, 3), 15, 20));
        }
        foreach (var activity in activities)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 100));

        }
    }
}