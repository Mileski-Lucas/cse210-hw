using System;

class ActivityLogger
{
    private Dictionary<string, int> _log = new Dictionary<string, int>();
    
    public void LogActivity(string activityName)
    {
        if (!_log.ContainsKey(activityName))
        {
            _log[activityName] = 0;
        }
        _log[activityName]++;
        DisplayLog();
    }
    
    public void DisplayLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in _log)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        Thread.Sleep(2000);
    }
}
