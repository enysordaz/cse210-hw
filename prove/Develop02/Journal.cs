using System;

public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator _promptGenerator;

    // Initialize an empty list of entries with Constructor
    public Journal() 
    {
        _entries = new List<Entry>();
        //Initialize prompt generator
        _promptGenerator = new PromptGenerator();
    }

    // Add new entries to the Journal from user input
    public void AddEntry()
    {
        string prompt = _promptGenerator.GenerateRandomPrompt();
        Console.Write("Please enter the date(mm/dd/yyyy): ");
        string _dateInput = Console.ReadLine();
        Console.WriteLine($"Today's Prompt: {prompt}");
        Console.Write("> ");
        string _content = Console.ReadLine();
    }

    // To display data input
    public void DisplayEntries()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.DisplayEntries();
        }
    }

    //Save Entries to a file 
    public void SaveToFile()
    {
        Console.Write("Please enter the filename to save your entries to: ");
        string _filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(_filename))
            {
                foreach (Entry entry in _entries) 
                {
                    writer.WriteLine($"{entry.DateCreated}  {entry.Content}");
                }
            }
            Console.WriteLine($"Journal entries saved to {_filename}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving entries to {_filename}: {e.Message}");
        }
    }

    // This loads the entries drom a file named by the user
    public void LoadFromFile()
    {
        Console.Write("Please enter the file name you would like to load from: ");
        string _filename = Console.ReadLine();
        try{
            using (StreamReader reader = new StreamReader(_filename)) 
            {
                while (!reader.EndOfStream)
                {
                    string dateString = reader.ReadLine();
                    string _content = reader.ReadLine();
                    Entry entry = new Entry(dateString, _content);
                    _entries.Add(entry);
                }
            }
        }
        catch (Exception e) 
        {
            Console.WriteLine($"Error loading entries from: {_filename}: {e.Message}");
        }

    }
}