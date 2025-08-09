// Program.cs
using System;

class Program
{
    // -----------------------------------------------------------------
    // Creativity and Exceeding Requirements:
    // I added a new type of goal called "NegativeGoal". This goal is used to
    // track bad habits and subtracts points from the user's score when an event
    // is recorded. This demonstrates the use of inheritance and polymorphism
    // by extending the program's functionality with a new goal type.
    // -----------------------------------------------------------------
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}