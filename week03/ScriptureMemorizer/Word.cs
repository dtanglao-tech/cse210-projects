using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText(bool hintMode = false)
    {
        if (_isHidden)
        {
            if (hintMode && _text.Length > 1)
                return _text[0] + new string('_', _text.Length - 1);
            else
                return new string('_', _text.Length);
        }
        return _text;
    }   
}