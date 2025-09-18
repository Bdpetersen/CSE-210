using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
        if (gradePercentage % 10 >= 7 && gradePercentage >= 60 && gradePercentage < 100)
        {
            letter += "+";
        }
        else if (gradePercentage % 10 < 3 && gradePercentage >= 60)
        {
            letter += "-";
        }
        Console.WriteLine($"Your letter grade is: {letter}");
    }
}