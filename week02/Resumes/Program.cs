// Program.cs
using System;
using System.Collections.Generic; // Although Resume.cs already uses it, it's good practice if you were to use it directly here.

namespace Resumes // Make sure this namespace matches your project's name
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create instances (objects) of Job (the job experiences)
            Job job1 = new Job();
            job1._company = "Microsoft";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2019;
            job1._endYear = 2022;

            Job job2 = new Job();
            job2._company = "Apple";
            job2._jobTitle = "Manager";
            job2._startYear = 2022;
            job2._endYear = 2023;

            // You can create more jobs if you want
            // Job job3 = new Job();
            // job3._company = "Google";
            // job3._jobTitle = "Senior Developer";
            // job3._startYear = 2023;
            // job3._endYear = 2025; // Or 0 if it's the current year and not ended yet

            // 2. Create an instance (object) of Resume
            Resume myResume = new Resume();
            myResume._name = "Allison Rose"; // Set the person's name

            // 3. Add the jobs we created to the resume's list of jobs
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);
            // myResume._jobs.Add(job3); // If you created job3, add it here

            // 4. Finally, call the Display() method of the Resume object.
            // This will display the person's name and then call the Display() for each job.
            myResume.Display();
        }
    }
}
