// Swimming.cs
using System;

public class Swimming : Activity
{
    private int _laps;
    private const double _lapLengthInMeters = 50;
    private const double _metersToMilesConversion = 0.000621371;

    public Swimming(string date, int minutes, int laps, EffortLevel effort) : base(date, minutes, effort)
    {
        _laps = laps;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        double distanceInMeters = _laps * _lapLengthInMeters;
        return distanceInMeters * _metersToMilesConversion;
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