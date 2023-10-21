using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public string Book => _book;
    public int Chapter => _chapter;
    public int VerseStart => _verseStart;
    public int VerseEnd => _verseEnd;

    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd ?? verseStart;
    }

    public override string ToString()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}