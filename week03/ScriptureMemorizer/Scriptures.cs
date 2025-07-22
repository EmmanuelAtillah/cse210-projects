using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide random words
    public void HideRandomWords(int count = 1)
    {
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        for (int i = 0; i < count && visibleIndexes.Count > 0; i++)
        {
            int randIndex = _random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randIndex];
            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randIndex);
        }
    }

    // Display text with optional first-letter hint
    public string GetDisplayText(bool showFirstLetter = false)
    {
        string text = "";

        foreach (var word in _words)
        {
            text += word.GetDisplayText(showFirstLetter) + " ";
        }

        return _reference.GetDisplayText() + "\n" + text.Trim();
    }

    // Check if all words are hidden
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
