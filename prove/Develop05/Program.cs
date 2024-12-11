class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Activities Program!");
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(20),
                "2" => new ReflectingActivity(20),
                "3" => new ListingActivity(20),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            activity.Start();
        }
    }
}