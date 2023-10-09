using System;

public class Resume
{
    public string _name;

    // Initialize list before using it
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        // data type use for "Job" in the loop
        foreach (Job job in _jobs)
        {
            // Display method on each job
            job.Display();
        }        
    }
}