using System;

public class Scripture
{
    public string _reference;

    public List<Word> _words = new List<Word>();

    //public Scripture (Reference reference, string text)
    //{
    //    reference = _reference;
    //}

    public void HideRandomWords(int numberToRide)
    {

    }

    public string GetDisplayText()
    {
        string text = $"{_reference}/{_reference}";

        return text;

    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

    
}