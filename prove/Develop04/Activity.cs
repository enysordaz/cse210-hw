using System;

public class Activity
{
    // Atributes
    private string _activityName;
    private int _activityTime;
    private string _message = "";

    //Constructors - Getters and Setters
    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }

    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.Write(" ");
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
        public int GetActivityTime()
    {
        Console.Write("\nHow many seconds would you like your session to be? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }

    // Methods
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }

    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"You have completed another {_activityTime} seconds of the {_activityName} Activity!");
        spinner.ShowSpinner();
    }
     public void CountDown(int time)
    {
        Console.WriteLine(); 
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));  // Overwrite line
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  ");  // last prompt
    }
}