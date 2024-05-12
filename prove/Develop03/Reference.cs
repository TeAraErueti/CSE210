public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _verse;

    public Reference (string book, int chapter, int verse_s)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse_s;
    }

    public Reference (string book, int chapter, int verse_s, int verse_e)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse_s;
        _endVerse = verse_e;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return ($"{_book} {_chapter}:{_startVerse}");
        }
        else
        {
            return ($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }

    public void setVerse()
    {
        _verse = Console.ReadLine();
    }

    public string GetVerse()
    {
        return _verse;
    }

    public string GetBook()
    {
        return _book;
    }
    
    public int GetChapter()
    {
        return _chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

}