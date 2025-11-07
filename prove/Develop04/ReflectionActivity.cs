using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    {
    }

    protected override void RunActivityLogic()
    {
        Random random = new Random();
        
        // 1. Select and display a random prompt
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {_prompts[promptIndex]} ---");
        
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5); // Give them time to prepare
        Console.Clear(); // Clear the countdown

        // 2. Loop through random questions for the duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int questionIndex = random.Next(_questions.Count);
            Console.Write($"> {_questions[questionIndex]} ");
            
            // Pauses with a spinner, giving time for reflection
            ShowSpinner(8); 
            Console.WriteLine();
        }
    }
}