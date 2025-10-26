// Word.cs

/// <summary>
/// Represents a single word within a scripture.
/// Tracks the word's text and its hidden state.
/// </summary>
public class Word
{
    private string _text;
    private bool _isHidden;

    /// <summary>
    /// Initializes a new instance of the Word class.
    /// </summary>
    /// <param name="text">The text of the word.</param>
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /// <summary>
    /// Marks the word as hidden.
    /// </summary>
    public void Hide()
    {
        _isHidden = true;
    }

    /// <summary>
    /// Checks if the word is currently hidden.
    /// </summary>
    /// <returns>True if the word is hidden, otherwise false.</returns>
    public bool IsHidden()
    {
        return _isHidden;
    }

    /// <summary>
    /// Gets the display text for the word.
    /// If hidden, returns underscores; otherwise, returns the actual word.
    /// </summary>
    /// <returns>A string representation of the word.</returns>
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Creates a string of underscores matching the word's length.
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}