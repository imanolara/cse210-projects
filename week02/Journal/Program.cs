// Program.cs
using System;
using System.Collections.Generic; // Needed for List<T>
using System.IO; // Needed for File operations (implicitly through Journal class)

namespace Journal // Make sure this namespace matches your project's name
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal(); // Create an instance of the Journal

            // List of prompts for the journal
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is one thing you learned today?", // Added custom prompt
                "What challenge did you overcome today?" // Added custom prompt
            };

            Random random = new Random(); // Object to pick random prompts

            int choice = 0;
            while (choice != 5) // Loop until the user chooses to Quit (option 5)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                // Try to parse the user's input as an integer
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1: // Write a new entry
                            // Get a random prompt
                            int promptIndex = random.Next(0, prompts.Count);
                            string randomPrompt = prompts[promptIndex];

                            Console.WriteLine(randomPrompt);
                            Console.Write("> ");
                            string userResponse = Console.ReadLine();

                            // Get current date with a specific format
                            // CAMBIO AGREGADO AQUÍ PARA EL FORMATO DE FECHA
                            string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); // Format: YYYY-MM-DD (e.g., 2025-07-10)

                            // Create a new Entry object
                            Entry newEntry = new Entry();
                            newEntry._date = currentDate;
                            newEntry._promptText = randomPrompt;
                            newEntry._entryText = userResponse;

                            myJournal.AddEntry(newEntry); // Add the entry to the journal
                            Console.WriteLine("Entry added successfully!");
                            break;

                        case 2: // Display the journal
                            myJournal.DisplayAllEntries();
                            break;

                        case 3: // Load the journal from a file
                            Console.Write("What is the filename? ");
                            string loadFilename = Console.ReadLine();
                            myJournal.LoadFromFile(loadFilename);
                            break;

                        case 4: // Save the journal to a file
                            Console.Write("What is the filename? ");
                            string saveFilename = Console.ReadLine();
                            myJournal.SaveToFile(saveFilename);
                            break;

                        case 5: // Quit
                            Console.WriteLine("Thank you for journaling today!");
                            break;

                        default: // Handle invalid choices
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.WriteLine(); // Add an empty line for spacing in the console
            }
        }
    }
}