using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter numbers: ");

            string inputResponse = Console.ReadLine();
            inputNumber = int.Parse(inputResponse);

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The highest number is: {max}");

        int low = numbers[0];

        foreach (int number in numbers)
        {
            if (number < low)
            {
                low = number;
            }
        }
        Console.WriteLine($"The lowest number is: {low}");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}