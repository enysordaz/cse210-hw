using System;

public class Entry 
{
    public string DateCreated{get;}
    public string Content{get;}

    // This can initialize the date and content from an entry from user input
    public Entry (string _dateInput, string _content){
        DateCreated = _dateInput;
        Content = _content;
    }

    //Display the Entries content
    public void DisplayEntries(){
        Console.WriteLine($"Date: {DateCreated}");
        Console.WriteLine($"Content: {Content}");
    }
}
