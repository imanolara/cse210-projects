// Running.cs
using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance, EffortLevel effort) : base(date, minutes, effort)
    {
        _distance = distance;
    }

    public override string GetActivityType()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}