using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _reference;
    private bool _allUnderscore;

    public Scripture(string reference, string scriptureText)
    {
        _reference = reference;
        _allUnderscore = false;

        string[] scriptureWords = scriptureText.Split(" ");

        foreach (string scriptureWord in scriptureWords)
        {
            Word wordForEachList = new Word(scriptureWord);
            _words.Add(wordForEachList);
        }
    }

    public void DisplayScripture()
    {
        while (_allUnderscore == false)
        {
            Console.Clear();
            Console.Write($"{_reference}");

            foreach (Word scriptureWord in _words)
            {
                scriptureWord.DisplayWord();
                Console.Write(" ");
            }

            Console.WriteLine("");
            Console.Write("To continue press enter or to finish type 'quit': ");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                Console.WriteLine();
                _allUnderscore = true;
            }
            else
            {
                _allUnderscore = CheckUnderscoreStatus();
                UnderscoreWords();
            }
        }
    }

    private bool CheckUnderscoreStatus()
    {
        bool allUnderscoreStatus = true;

        foreach (Word scriptureWord in _words)
        {
            bool wordDisplayStatus = scriptureWord.GetDisplay();
            if (wordDisplayStatus == true)
            {
                allUnderscoreStatus = false;
            }
        }
        return allUnderscoreStatus;
    }

    private void UnderscoreWords()
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