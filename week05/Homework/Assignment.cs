using System;

public class Assignment
{
    protected string _studentName = "";
    private string _topic = "";

    public void SetSummary(string Name, string Topic)
    {

        _studentName = Name;
        _topic = Topic;
        
    } 

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }


}