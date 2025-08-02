// AffirmationActivity.cs
using System;
using System.Collections.Generic;

public class AffirmationActivity : Activity
{
    private List<string> _affirmations = new List<string>
    {
        "I am worthy of love and respect.",
        "I have the strength to overcome any challenge.",
        "I choose to be happy and positive today.",
        "My mind is calm, and my body is relaxed.",
        "I am grateful for all the good things in my life."
    };

    private Random _random = new Random();

    public AffirmationActivity()
    {
        _name = "Affirmation Activity";
        _description = "This activity will help you strengthen your mindset by having you focus on positive affirmations. You will repeat a series of affirmations to yourself for a set duration.";
    }

    public void Run()
    {
        ShowStartingMessage();
        
        Console.WriteLine("Clear your mind and focus on the following affirmations.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string affirmation = GetRandomAffirmation();
            Console.WriteLine($"--- {affirmation} ---");
            Console.Write("Repeat this to yourself for a few seconds...");
            ShowSpinner(5); // Show a spinner for 5 seconds per affirmation
            Console.Clear();
        }

        ShowEndingMessage();
    }
    
    private string GetRandomAffirmation()
    {
        int index = _random.Next(0, _affirmations.Count);
        return _affirmations[index];
    }
}