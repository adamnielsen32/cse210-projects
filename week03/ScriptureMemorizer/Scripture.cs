using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public string GetScriptureText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        scriptureText = scriptureText.Trim();
        return $"{referenceText} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void HideRandomWords(int numberToHide)
{
    Random random = new Random();


        List<Word> visibleWords = new List<Word>();
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    
    int hideCount = Math.Min(numberToHide, visibleWords.Count);
    for (int i = 0; i < hideCount; i++)
    {
        
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();

       
        visibleWords.RemoveAt(index);
    }
}
}
