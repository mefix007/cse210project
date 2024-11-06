using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Score: ");
        string score = Console.ReadLine();

        int x = int.Parse(score);

        if (x >= 90)
        {
            Console.WriteLine("Your Grade is A");
        }
        else if (x >= 80)
        {
            Console.WriteLine("Your Grade is B");

        }
        else if (x >= 70)
        {
            Console.WriteLine("Your Grade is C");

        }
        else if (x >= 60)
        {
            Console.WriteLine("Your Grade is D");

        }
        else
        {
            Console.WriteLine("Your Grade is F");

        }

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else
        {
            Console.WriteLine("Put in more effort next time");
        }

    }
}