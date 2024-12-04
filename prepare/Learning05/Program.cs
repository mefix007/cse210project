using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeWorkList());
        Console.WriteLine(new string('-', 40));


        WritingAssignment assignment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritinginformation());
        Console.WriteLine(new string('-', 40));

    }
}