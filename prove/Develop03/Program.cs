using System;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements, this program implements the stretch challenge
        // of ensuring that the random words chosen to be hidden are selected only
        // from the set of words that are not already hidden. This avoids redundant
        // selections and makes the process feel more direct.

        // Create a scripture object (using the multi-verse constructor for Reference)
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        // Main loop continues as long as not all words are hidden and the user hasn't quit
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clear console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Add a blank line for spacing

            // Prompt user
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                // Hide 3 random words
                scripture.HideRandomWords(3);
            }
        }
        
        // Final display after loop ends (either by quitting or finishing)
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood boy!");
    }
}