using System;

public class Reference
{

    private string _book;

    private int _chapter;

    private int _verse;

    private int _startVerse;

    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

        public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        
    }

        public string GetDisplayText()
    {
        string text = "";
        if(_verse > 0 )
        {
            text = $"{_book} {_chapter}:{_verse}. ";
        }
        else
        {
            text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}. ";
        }
        

        return text;

    }

    
}