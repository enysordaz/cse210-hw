using System;

public class Reference
{
    // Attributes that form the reference
    private string _reference;
    private string _book;
    private string _chapter;
    private string _verse;

    // This displays the reference string or message to the user
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

        _reference = $"{book} {chapter}:{verse}";
    }

    // Using the get to encapsulate the reference and display it
    public string GetReference()
    {
        return _reference;
    }

}