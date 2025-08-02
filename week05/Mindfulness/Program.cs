// Program.cs
using System;

class Program
{
    // -----------------------------------------------------------------
    // Creativity and Exceeding Requirements:
    // I added a fourth activity called "Affirmation Activity" to help users
    // focus on positive thoughts for a set duration. This new activity
    // extends the principles of inheritance demonstrated in the project
    // by having its own unique behavior while sharing common methods
    // from the base 'Activity' class.
    // -----------------------------------------------------------------

    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start affirmation activity"); // New option
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    AffirmationActivity affirmationActivity = new AffirmationActivity();
                    affirmationActivity.Run();
                    break;
                case "5":
                    // Quit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}