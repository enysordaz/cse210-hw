using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guess = -1;

        //start while loop
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Start conditional statements
            if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else if (guess > magicNumber) 
            {
                Console.WriteLine("Guess lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}