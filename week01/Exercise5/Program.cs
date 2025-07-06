using System; // Necessary for Console.WriteLine, Console.ReadLine, etc.

namespace Exercise5
{
    class Program
    {
        // The Main method is the entry point of our program.
        static void Main(string[] args)
        {
            // 1. Call DisplayWelcome to show the welcome message.
            DisplayWelcome();

            // 2. Prompt for the user's name and store it.
            string userName = PromptUserName();

            // 3. Prompt for the user's favorite number and store it.
            int favoriteNumber = PromptUserNumber();

            // 4. Calculate the square of the favorite number.
            int squaredNumber = SquareNumber(favoriteNumber);

            // 5. Display the final result using the name and the squared number.
            DisplayResult(userName, squaredNumber);
        }

        // --- Function Definitions ---

        // Function to display a welcome message. It takes no parameters and returns nothing (void).
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Function to prompt for the user's name. It takes no parameters, returns a string.
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Function to prompt for the user's favorite number. It takes no parameters, returns an int.
        static int PromptUserNumber()
        {
            int number;
            // Use a loop to ensure the user enters a valid number.
            while (true)
            {
                Console.Write("Please enter your favorite number: ");
                string input = Console.ReadLine();

                // int.TryParse attempts to convert the string to an int. If successful, it returns true.
                if (int.TryParse(input, out number))
                {
                    break; // Exit the loop if the input is valid.
                }
                else
                {
                    Console.WriteLine("That's not a valid number. Please try again.");
                }
            }
            return number;
        }

        // Function to calculate the square of a number. It takes an int, returns an int.
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Function to display the final result. It takes the name (string) and the squared number (int), returns nothing (void).
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}