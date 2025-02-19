using System;

public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(int minutes, double speedKph) : base(minutes)
    {
        this._speedKph = speedKph;
    }

    public override double GetDistance() => (_speedKph * Minutes) / 60;
    public override double GetSpeed() => _speedKph;
    public override double GetPace() => 60 / _speedKph;
}
