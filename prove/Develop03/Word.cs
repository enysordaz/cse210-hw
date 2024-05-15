using System;

public class Word
{
    private string _word;
    private string _removedWord;
    private bool _display;

    public Word(string word)
    {
        _word = word;
        _removedWord = new string('_', word.Length);
        _display = true;
    }

    public bool GetDisplay()
    {
        return _display;
    }
    public void SetDisplay(bool display)
    {
        _display = display;
    }

    public string DisplayWord()
    {
        return DisplayWord();
    }

}