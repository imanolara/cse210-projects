// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    // -----------------------------------------------------------------
    // Creativity and Exceeding Requirements:
    // I added a new feature to track the perceived "Effort" level for each activity.
    // I created an enum called `EffortLevel` and added a member variable to the
    // base `Activity` class. The `GetSummary` method was then updated to
    // display this new piece of information, adding a simple but engaging
    // gamification element to the program.
    // -----------------------------------------------------------------
    static void Main(string[] args)
    {
        // Crea una lista de actividades del tipo base Activity
        List<Activity> activities = new List<Activity>();

        // Crea instancias de cada clase derivada, añadiendo el nivel de esfuerzo
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0, EffortLevel.Intense);
        Cycling cyclingActivity = new Cycling("03 Nov 2022", 30, 9.7, EffortLevel.Moderate);
        Swimming swimmingActivity = new Swimming("03 Nov 2022", 30, 20, EffortLevel.Light);

        // Añade todas las actividades a la misma lista
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Itera a través de la lista y llama al método GetSummary()
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}