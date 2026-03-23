using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public string GetDisplayText(bool hintMode = false)
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText(hintMode) + " ";
        }
        return text.Trim();
    }

    public double GetProgress()
    {
        int hidden = _words.Count(w => w.IsHidden());
        return (double)hidden / _words.Count * 100;
    }

}