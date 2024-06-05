using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        //Running 
        Running running1 = new Running("May 25th, 2024", 30, 2.5);
        exerciseList.Add(running1);

        Running running2 = new Running("June 5th, 2024", 45, 3.1);
        exerciseList.Add(running2);

        //Stationary Bicycle
        StationaryBicycles stationaryBicycles1 = new StationaryBicycles("May 22th, 2024", 40, 10);
        exerciseList.Add(stationaryBicycles1);

        StationaryBicycles stationaryBicycles2 = new StationaryBicycles("May 27th, 2024", 60, 15);
        exerciseList.Add(stationaryBicycles2);

        // Swimming
        Swimming swimming1 = new Swimming("June 8th, 2024", 30, 8);
        exerciseList.Add(swimming1);

        Swimming swimming2 = new Swimming("June 16th, 2024", 45, 10);
        exerciseList.Add(swimming2);

        // Display in the Console
        Console.WriteLine("Exercises: ");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}