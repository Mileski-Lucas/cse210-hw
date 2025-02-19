using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthKm = 0.05; // 50 meters in km

    public Swimming(int minutes, int laps) : base(minutes)
    {
        this._laps = laps;
    }

    public override double GetDistance() => _laps * LapLengthKm;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}