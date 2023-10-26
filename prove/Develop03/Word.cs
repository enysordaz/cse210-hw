using System;
using System.Security.Principal;

public class Word
{
    private string _word;
    private string _underscoreWord;
    private bool _display;

    public Word(string word)
    {
        _word = word;
        _underscoreWord = new string('_', word.Length);
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

    public void DisplayWord()
    {
        if (_display == true)
        {
            Console.Write(_word);
        }
        else 
        {
            Console.Write(_underscoreWord);
        }
    }

}