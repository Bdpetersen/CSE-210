// Scripture.cs

/// <summary>
/// Represents a scripture, including its reference and text.
/// Manages hiding words and displaying the scripture.
/// </summary>
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Find all words that are not currently hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide; i++)
        {
            // If all words are hidden, stop trying to hide more.
            if (visibleWords.Count == 0)
            {
                break;
            }

            // Pick a random word from the list of visible words
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            
            // Remove the word from our temporary list so we don't pick it again in this loop
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        // The .All() method checks if every item in the list meets the condition.
        return _words.All(w => w.IsHidden());
    }
}