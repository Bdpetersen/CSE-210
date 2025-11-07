using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {
    }

    protected override void RunActivityLogic()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            // Breathe In
            Console.Write("Breathe in...");
            ShowCountdown(4); // 4 seconds to breathe in
            Console.WriteLine();

            // Check if time is up before the next step
            if (DateTime.Now >= endTime) break; 
            
            // Breathe Out
            Console.Write("Breathe out...");
            ShowCountdown(6); // 6 seconds to breathe out
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}