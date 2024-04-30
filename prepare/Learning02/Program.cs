using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates new instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Calls function display from Job class for job1
        //job1.Display();

        // Creates a new Job instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Creates a new Job instance
        Job job3 = new Job();
        job3._jobTitle = "Product Designer";
        job3._company = "Google";
        job3._startYear = 2023;
        job3._endYear = 2024;

        // Calls function display from Job class for job2
        //job2.Display();

        // Creates new instance for Resume
        Resume myResume = new Resume();
        myResume._name = "Eve Williams";
        // Adds the information from the Job class to its class
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        // Displays the Resume
        myResume.Display();

    }
}