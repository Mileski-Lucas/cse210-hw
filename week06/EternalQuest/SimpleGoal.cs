using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points!");
        }
    }

    public void SetCompletion(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"[{(_isComplete ? "X" : " ")}] {base.GetDetailsString()}";
    public override string GetStringRepresentation() => $"Simple,{_shortName},{_description},{_points},{_isComplete}";

}
