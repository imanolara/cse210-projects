// Reference.cs
using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse; // Using 0 to indicate no range (single verse)

    // Constructor for a single reference (e.g., "John 3:16")
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0; // No end verse for a single reference
    }

    // Constructor for a range of references (e.g., "Proverbs 3:5-6")
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get the formatted reference text
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            // Format for a single verse
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            // Format for a range of verses
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}