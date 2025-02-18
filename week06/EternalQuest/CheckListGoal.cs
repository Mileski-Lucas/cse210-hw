using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded! You earned {_points} points.");

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Checklist goal '{_shortName}' completed! Bonus {_bonus} points awarded!");
        }
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
        
    }

    public int GetBonus() => _bonus;

    public override bool IsComplete() => _amountCompleted >= _target;

     public override string GetDetailsString()
     {
        if (_amountCompleted >= _target)
        {
            return $"[X] {base.GetDetailsString()} Completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {base.GetDetailsString()} Completed {_amountCompleted}/{_target}";
        }
        

     }

    public override string GetStringRepresentation() => $"Checklist,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";

}