// Word.cs
using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize a word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, the word is not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word (set it as not hidden)
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the text to display (word or underscores)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Replaces the word with underscores of the same length
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}