// Resume.cs
using System; // Needed for Console.WriteLine (for Display())
using System.Collections.Generic; // Crucial for using List<T>

public class Resume
{
    // Member variable for the person's name
    public string _name;

    // Member variable for the list of jobs. Initialize it immediately!
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate over each Job in the _jobs list
        foreach (Job job in _jobs)
        {
            // Call the Display() method of each individual Job object
            job.Display();
        }
    }
}