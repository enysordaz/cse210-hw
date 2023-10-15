using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Creates a new instance of Journal
        Journal _journal = new Journal();

        //Welcome message or banner
        Console.WriteLine("Welcome to your Journal!");
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");
            // Request user selection
            Console.Write("What would you like to do(1-5)? ");
            string _choice = Console.ReadLine();

            //Calling class method with user selection
            switch (_choice) 
            {
                //Adds new entry
                case "1":
                _journal.AddEntry();
                break;

                //Display the added entries
                case "2":
                _journal.DisplayEntries();
                break;

                //Load the entries from a file
                case "3":
                _journal.LoadFromFile();
                break;

                //Saves entries to a file
                case "4":
                _journal.SaveToFile();
                break;

                //Exits program
                case "5":
                Console.WriteLine("Thank you for writing! See you soon!");
                return;

                //Handles invalid input
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5");
                break;
            }
        }


    }
}