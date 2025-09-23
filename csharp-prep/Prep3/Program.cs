using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Guess the Magic Number!");
        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);
        int guess;
        do
        {
            Console.Write("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
        } while (guess != magicNumber);
        Console.WriteLine("That's correct!");
    }
}