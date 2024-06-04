using System;

class Program
{
    static void Main(string[] args)
    {
        string menuSelected = " ";

        GoalsTracker goals = new GoalsTracker();

    while (menuSelected != "6") 
    {
        int points = goals.GetAccumulatedPoints();

        Console.WriteLine("Welcome to the Eternal Quest!!");
        Console.WriteLine("Through this game you will be able to track and save your goals, and win points depending on what you are accomplishing.");
        Console.WriteLine(); // Empty space to devide points and menu
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");

        menuSelected = Console.ReadLine();

        switch (menuSelected)  // Each case holds a menu option selected by the user
        {
            case "1": // Has the options to different goals
                // This calls the dessignated class and child classes

                Console.WriteLine("The Types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                switch (goalType) 
                {
                    case "1":
                        SimpleGoal newSimpleGoal = new SimpleGoal();
                        newSimpleGoal.CreateChildGoal();
                        goals.addGoal(newSimpleGoal);
                        break;
                    
                    case "2":
                        EternalGoal newEternalGoal = new EternalGoal();
                        newEternalGoal.CreateChildGoal();
                        goals.addGoal(newEternalGoal);
                        break;

                    case "3":
                        ChecklistGoal newChecklistGoal = new ChecklistGoal();
                        newChecklistGoal.CreateChildGoal();
                        goals.addGoal(newChecklistGoal);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid goal type. Please try again.");
                        break;
                }
                break;

            case "2":
                goals.ListGoals(); 
                break;

            case "3":
                goals.SaveGoal(); 
                break;

            case "4":
                goals.LoadGoal(); 
                break;

            case "5":
                goals.RecordEventInTracker();
                break;

            case "6":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Please select a valid number from the menu options.");
                break;
            }
        }
    }
}