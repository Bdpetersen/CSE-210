using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Public method to control the full activity flow
    public void Run()
    {
        DisplayStartingMessage();
        
        // This method will be implemented uniquely by each derived class
        RunActivityLogic(); 
        
        DisplayEndingMessage();
    }

    // Abstract method: MUST be implemented by derived classes
    protected abstract void RunActivityLogic(); 

    // --- Common Start and End Methods ---

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session to be? ");
        string input = Console.ReadLine();
        // Set duration, using a default if parsing fails
        if (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            _duration = 30; 
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
        }
        
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5); // Pause and animate before starting
        Console.WriteLine();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(4); 
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(4);
    }

    // --- Animation Helpers ---

    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); // Pause for a quarter second
            Console.Write("\b \b"); // Erase and move cursor back
            
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            // Puts the number in a fixed-width format to ensure clean overwriting
            Console.Write(i.ToString().PadLeft(2)); 
            Thread.Sleep(1000); 
            Console.Write("\b\b  \b\b"); // Erase two characters (for two-digit numbers)
        }
    }
}