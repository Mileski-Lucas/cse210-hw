using System;

public class WritingAssignment : Assignment
{
    private string _title = "";
    
    public void SetHomeWork(string Title)
    {
        _title = Title;
        
    }

    public string GetWritingtInformation()
    {
        return $"{GetSummary()}\n{_title} by {_studentName}";
    }
    
}