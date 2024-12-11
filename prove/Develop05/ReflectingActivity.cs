public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectingActivity(int duration)
        : base("Reflecting Activity",
               "This activity helps you reflect on moments of strength and resilience.",
               duration)
    {
    }

    public override void Run()
    {
        Random random = new Random();
        while (_duration > 0)
        {
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine($"\nReflect on this: {prompt}");
            ShowCountDown(5);
            _duration -= 5;
        }
    }
}
