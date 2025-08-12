// Activity.cs
using System;

public enum EffortLevel
{
    Light,
    Moderate,
    Intense
}

public class Activity
{
    private string _date;
    private int _minutes;
    private EffortLevel _effort;

    public Activity(string date, int minutes, EffortLevel effort)
    {
        _date = date;
        _minutes = minutes;
        _effort = effort;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual string GetActivityType()
    {
        return "Activity";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
    
    public string GetEffortScore()
    {
        return _effort.ToString();
    }

    public string GetSummary()
    {
        return $"{_date} {GetActivityType()} ({_minutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile, Effort: {GetEffortScore()}";
    }
}