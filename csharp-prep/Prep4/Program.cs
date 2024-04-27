using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // START LOOP
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Place a number (Enter 0 to quit): ");
            // convert the input to integral
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            // Only to add a number to the list if it not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }
        // Calculate sum and start for loop
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        // display result
        Console.WriteLine($"The result of the sum is: {sum}");

        // Calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max number using foreach loop and if or conditional statement
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // The new max is found if this number is greater than the maximun
                max = number;
            }
        }
        // Display result
        Console.WriteLine($"The max number is: {max}");
    }
}