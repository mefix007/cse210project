using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is the magic number?");
        string magicNumber = Console.ReadLine();
        Console.Write("what is your guess number?");
        string guessNumber = Console.ReadLine();

        int x = int.Parse(magicNumber);
        int y = int.Parse(guessNumber);

        if (x > y)
        {
            Console.WriteLine("Higher");
        }
        else if (x == y)
        {
            Console.WriteLine("You guess it");
        }
        else
        {
            Console.WriteLine("Lower");
        }

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("what is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess right!");
            }
        }
    }

}