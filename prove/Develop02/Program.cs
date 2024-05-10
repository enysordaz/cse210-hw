using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "What happened today?",
                "What was the best thing that happened today?",
                "What was the most intersting thing that I saw or heard today?",
                "What was the most challenging thing I faced today?",
                "What am I grateful for today?",
                "What did I learn today?",
                "What was the most fun thing I did today?",
                "What was the most surprising thing that happened today?",
                "What did I do today that I am proud of?",
                "What are my goals and objectives for this week?",
                "How can I serve others more constantly?",
                "Which scripture or talk motivated me today?",
                "Who do I need to pray for today?",
                "What do I love most about myself?",
                "What activities and practices make me feel more in tune with the Holy Ghost?",
                "What is one way I can creatively express gratitude, love, or appreciation for others?",
                "What are my top priorities for the day?",
                "What did I learn today?",
                "What was a moment of joy, delight, or happiness today?",
                "What did I do to bring positivity into my day?", 
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Until next time, keep writing!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}