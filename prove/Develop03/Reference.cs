public class Reference
{
    private string _book;
    private int _startVerse;
    private int _endVerse;
    private int _chapter;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _chapter = chapter; 
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _chapter = chapter; 
    }
    public string Display()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }
    public string DispayVerses()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}