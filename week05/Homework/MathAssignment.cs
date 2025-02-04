using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public void SetHomeWork(string Textbook, string Problems)
    {
        _textbookSection = Textbook;
        _problems = Problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}\nSection {_textbookSection} Problems {_problems}";
    }
    
}