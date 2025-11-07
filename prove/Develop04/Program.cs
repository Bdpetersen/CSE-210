using System;

class Program
{
    // Add comments here describing how you exceeded the core requirements!
    // Example: // I exceeded requirements by making sure no random reflection questions are repeated in a session.

    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Activity currentActivity = null;

            if (choice == "1")
            {
                currentActivity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                currentActivity = new ReflectionActivity();
            }
            else if (choice == "3")
            {
                currentActivity = new ListingActivity();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
                continue;
            }

            if (currentActivity != null)
            {
                currentActivity.Run(); // Calls the Run method on the specific derived object
            }
        }
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}