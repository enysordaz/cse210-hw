using System;

public class Comments
{
    private string _commenterName;
    private string _text;

    public Comments(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_commenterName} - {_text}");
    }
}