using System;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string ResponseText { get; set; }

    public Entry(string promptText, string responseText)
    {
        this.Date = DateTime.Now.ToShortDateString();
        this.PromptText = promptText;
        this.ResponseText = responseText;
    }

    public Entry()
    {
        this.Date = "";
        this.PromptText = "";
        this.ResponseText = "";
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"> {ResponseText}\n");
    }

    public string ToFileString()
    {
        const string Separator = "~~~|~~~";
        return $"{Date}{Separator}{PromptText}{Separator}{ResponseText}";
    }
}
