using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty. Write an entry or load a file first.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---\n");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("--- End of Journal ---\n");
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    outputFile.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine($"\nJournal successfully saved to: {filename}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred while saving the file: {ex.Message}\n");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            _entries.Clear(); 
            
            const string Separator = "~~~|~~~";

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { Separator }, StringSplitOptions.None);

                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry.Date = parts[0];
                    entry.PromptText = parts[1];
                    entry.ResponseText = parts[2];
                    _entries.Add(entry);
                }
            }
            
            Console.WriteLine($"\nJournal successfully loaded from: {filename}. Total entries loaded: {_entries.Count}\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\nError: File not found at '{filename}'. Please check the filename and try again.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn unexpected error occurred while loading the file: {ex.Message}\n");
        }
    }
}
