public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }


    public List<Word> GetWords()
    {
        return _words;
    }

    public string GetScriptureText()
    {
        return $"{_reference.GetReferenceString()} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
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
}