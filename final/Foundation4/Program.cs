using System;

class Program
{
    static void Main(string[] args)
        {
            // Create a list of Activity objects
            List<Activity> activities = new List<Activity>();

            // Create one of each type
            Running run = new Running("03 Nov 2022", 30, 3.0);
            Cycling bike = new Cycling("04 Nov 2022", 30, 15.0); // 15 mph
            Swimming swim = new Swimming("05 Nov 2022", 30, 20); // 20 laps

            // Add them to the list
            activities.Add(run);
            activities.Add(bike);
            activities.Add(swim);

            // Iterate and display summaries
            Console.WriteLine("Exercise Tracking Summary:");
            Console.WriteLine("--------------------------");
            
            foreach (Activity activity in activities)
            {
                // This calls the GetSummary() in the base class, 
                // which calls the overridden calculations in the derived classes.
                Console.WriteLine(activity.GetSummary());
            }
        }
}