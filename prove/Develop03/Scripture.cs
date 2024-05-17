using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _reference;
    private bool _allHidden;

    public Scripture(string reference, string scriptureMessage)
    {
        _reference = reference;
        _allHidden = false;

        string[] scriptureWords = scriptureMessage.Split(" ");

        foreach (string scriptureWord in scriptureWords)
        {
            Word wordForList = new Word(scriptureWord);
            _words.Add(wordForList);
        }
    }

    public void DisplayScripture()
    {
        while (_allHidden == false)
        {
            Console.Clear();
            Console.Write($"{_reference} ");

            foreach (Word scriptureWord in _words)
            {
                scriptureWord.DisplayWord();
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                Console.WriteLine();
                Console.WriteLine();
                _allHidden = true;
            }
            else
            {
                _allHidden = CheckHiddenStatus();
                HideWords();
            }
        }
    }

    private bool CheckHiddenStatus()
    {
        bool allHiddenStatus = true;

        foreach (Word scriptureWord in _words)
        {
            bool wordDisplayStatus = scriptureWord.GetDisplay();
            if (wordDisplayStatus == true)
            {
                allHiddenStatus = false;
            }
        }
        return allHiddenStatus;
    }

    private void HideWords()
    {
        int counter = 0;

        while (counter < 3)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _words.Count);
            _words[randomIndex].SetDisplay(false);
            counter += 1;
        }
    }
}