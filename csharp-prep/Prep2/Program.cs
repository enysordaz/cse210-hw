using System;

class Program
{
    static void Main(string[] args)
    {
        // Promt the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradeLetter = int.Parse(gradePercentage);

        //start the conditional statements
        if (gradeLetter >= 90)
        {
            Console.WriteLine("Congratulations! You passed with an A! Amazing");
        }
        else if (gradeLetter >= 80)
        {
            Console.WriteLine("Congratulations! You passed with a B! You got this!");
        }
        else if (gradeLetter >= 70)
        {
            Console.WriteLine("You passed with a C! You can do it!");
        }
        else if (gradeLetter >= 60)
        {
            Console.WriteLine("You'll do better next time, you failed with a D");
        }
        else if (gradeLetter < 60)
        {
            Console.WriteLine("You can do better next time, you failed with a F");
        }
        // in case of wrong or no recognition of percentage
        else
        {
            Console.WriteLine("I can't recognize the percentage grade");
        }
    }
    // end of program
}