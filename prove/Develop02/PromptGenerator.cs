using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today that I want to remember?",
            "What small, simple good did I do for someone else?"
        };
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    
    public void RemovePrompt(int index)
    {
        if (index >= 0 && index < _prompts.Count)
        {
            _prompts.RemoveAt(index);
        }
    }
}
