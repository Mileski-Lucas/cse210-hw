using System;

public class Scripture
{
    private string _reference;

    public List<Word> _words = new List<Word>();

    public Scripture(string reference)
    {
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && IsCompletelyHidden() == false)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (var word in _words)
        {
            text = text+$"{word.GetDisplayText()} ";
        }
        
        return _reference+$" {text.Trim()}";

    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}