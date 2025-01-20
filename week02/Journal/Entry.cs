using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
    }
}