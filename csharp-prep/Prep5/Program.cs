using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }
    
    // Function to display the welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("WELCOME TO THE PROGRAM!");
    }

    // function to save user name 
    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // function to save the users favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // Function to calculate the square number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //Function to display the result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}