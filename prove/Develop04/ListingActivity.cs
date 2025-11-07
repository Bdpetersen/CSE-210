using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        // Relevant to the user's saved information:
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
    }

    protected override void RunActivityLogic()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        
        // 1. Select and display a random prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[promptIndex]} ---");
        
        Console.Write("You may begin in: ");
        ShowCountdown(5); // Give them time to think

        // 2. Collect user input for the duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;
        
        Console.WriteLine();
        // The core listing phase
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            // Use ReadLine() to get input, but don't wait if time is up
            // This setup relies on the user typing quickly and hitting Enter.
            Console.ReadLine(); 
            count++;
        }

        // 3. Display the result
        Console.WriteLine($"You listed {count} items!");
    }
}