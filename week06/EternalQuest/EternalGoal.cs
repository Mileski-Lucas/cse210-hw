using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{_shortName}' recorded! You earned {_points} points!");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"[∞] {base.GetDetailsString()}";

    public override string GetStringRepresentation() => $"Eternal,{_shortName},{_description},{_points}";
}