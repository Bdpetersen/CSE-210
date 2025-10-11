using System;

class Program
{
    // Creative Requirement: Added a menu option (6) to allow the user to 
    // manage (add or remove) prompts, making the journal more customizable.
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myJournal = new Journal();
        string choice = "";

        Console.WriteLine("Welcome to the C# Journal Program!");
        
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from file");
            Console.WriteLine("4. Save the journal to file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Manage Prompts");
            
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\n--- Prompt: {prompt} ---");
                    Console.Write("Your Response: ");
                    string response = Console.ReadLine();
                    
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        myJournal.AddEntry(prompt, response);
                        Console.WriteLine("\nEntry saved successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nResponse cannot be empty. Entry cancelled.\n");
                    }
                    break;
                
                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to load (e.g., myJournal.txt): ");
                    string loadFile = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(loadFile))
                    {
                        myJournal.LoadFromFile(loadFile);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid filename. Operation cancelled.\n");
                    }
                    break;

                case "4":
                    Console.Write("Enter the filename to save (e.g., myJournal.txt): ");
                    string saveFile = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(saveFile))
                    {
                        myJournal.SaveToFile(saveFile);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid filename. Operation cancelled.\n");
                    }
                    break;

                case "5":
                    Console.WriteLine("\nThank you for using the Journal Program. Goodbye!");
                    break;
                
                case "6":
                    Console.WriteLine("\n--- Prompt Management ---");
                    Console.WriteLine("1. Add a new prompt");
                    Console.WriteLine("2. Remove a prompt");
                    Console.Write("Select an option (1 or 2): ");
                    string manageChoice = Console.ReadLine();

                    if (manageChoice == "1")
                    {
                        Console.Write("Enter the new prompt text: ");
                        string newPrompt = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newPrompt))
                        {
                            promptGenerator.AddPrompt(newPrompt);
                            Console.WriteLine("\nPrompt added successfully!\n");
                        }
                    }
                    else if (manageChoice == "2")
                    {
                        Console.WriteLine("\n--- Current Prompts ---");
                        for (int i = 0; i < promptGenerator._prompts.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {promptGenerator._prompts[i]}");
                        }
                        
                        Console.Write("Enter the number of the prompt to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int indexToRemove) && indexToRemove > 0 && indexToRemove <= promptGenerator._prompts.Count)
                        {
                            promptGenerator.RemovePrompt(indexToRemove - 1);
                            Console.WriteLine("\nPrompt removed successfully!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid selection. No prompt removed.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid prompt management choice.\n");
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 6.\n");
                    break;
            }
        }
    }
}
