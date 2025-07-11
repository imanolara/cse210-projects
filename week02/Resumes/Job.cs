// Job.cs
using System; // Needed for Console.WriteLine

public class Job
{
    // Member variables (attributes) for the job
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Method to display the job information
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}