// NegativeGoal.cs
using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Oh no! You have lost {_points} points.");
    }

    public override bool IsComplete()
    {
        // Las metas negativas nunca se "completan", son un recordatorio constante
        return false;
    }

    public override string GetDetailsString()
    {
        // Las metas negativas no tienen estado de completado
        return $"[ ] {_shortName} ({_description}) -- (Negative Goal)";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}