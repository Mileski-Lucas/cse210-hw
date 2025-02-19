using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>
        {
            new Running(30, 4.8),
            new Cycling(60, 20),
            new Swimming(45, 30)
        };

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}