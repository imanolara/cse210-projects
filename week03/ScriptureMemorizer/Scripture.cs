// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq; // Required for .Any() and .Where() methods

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random; // For selecting random words

    // Constructor: Receives the reference and the verse text as strings
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random(); // Initialize the random number generator

        // Splits the text into words and creates Word objects
        // Handles common punctuation as delimiters and removes empty entries
        string[] rawWords = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string rawWord in rawWords)
        {
            _words.Add(new Word(rawWord));
        }
    }

    // Hides a specified number of random words that are not already hidden
    public void HideRandomWords(int count)
    {
        // Filter words that are not yet hidden
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();

        if (unhiddenWords.Count == 0)
        {
            return; // No words to hide
        }

        // Hide 'count' words, or all remaining if 'count' is greater
        for (int i = 0; i < count && unhiddenWords.Count > 0; i++)
        {
            int indexToHide = _random.Next(0, unhiddenWords.Count);
            unhiddenWords[indexToHide].Hide();

            // Remove the hidden word from the temporary list to avoid re-selecting it
            unhiddenWords.RemoveAt(indexToHide);
        }
    }

    // Gets the full scripture text with hidden words displayed as underscores
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}"; // Combines reference and text
    }

    // Checks if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden()); // Uses LINQ to check if all are hidden
    }
}