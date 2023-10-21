using System;


class Word
{
    private string _text;
    private bool _isHidden;

    public string Text => _text;
    public bool IsHidden => _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are initially not hidden
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
}
