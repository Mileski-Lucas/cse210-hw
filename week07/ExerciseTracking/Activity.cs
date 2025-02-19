using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(int minutes)
    {
        this._date = DateTime.Now;
        this._minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F2} min per km";
    }
}