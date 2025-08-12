// Cycling.cs
using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed, EffortLevel effort) : base(date, minutes, effort)
    {
        _speed = speed;
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}