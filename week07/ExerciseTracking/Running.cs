using System;

public class Running : Activity
{
    private double _distanceKm;

    public Running(int minutes, double distanceKm) : base(minutes)
    {
        this._distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}