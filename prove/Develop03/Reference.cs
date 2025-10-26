public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    /// <summary>
    /// Initializes a new instance of the Reference class for a single verse.
    /// </summary>
    /// <param name="book">The book of the scripture (e.g., "John").</param>
    /// <param name="chapter">The chapter number.</param>
    /// <param name="verse">The verse number.</param>
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0; // Use 0 or -1 to indicate no end verse
    }

    /// <summary>
    /// Initializes a new instance of the Reference class for a verse range.
    /// </summary>
    /// <param name="book">The book of the scripture (e.g., "Proverbs").</param>
    /// <param name="chapter">The chapter number.</param>
    /// <param name="startVerse">The starting verse number.</param>
    /// <param name="endVerse">The ending verse number.</param>
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    /// <summary>
    /// Returns the fully formatted reference string.
    /// </summary>
    /// <returns>A string representation of the reference (e.g., "John 3:16" or "Proverbs 3:5-6").</returns>
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}