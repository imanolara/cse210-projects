// Program.cs
using System; // Required for Console and Environment

class Program
{
    static void Main(string[] args)
    {
        // *** Section for exceeding requirements: You can define multiple scriptures here ***
        // For now, we'll use a fixed one, but you could load from a file or have a collection.
        Reference reference1 = new Reference("John", 3, 16);
        string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture1 = new Scripture(reference1, text1);

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        string text2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture2 = new Scripture(reference2, text2);

        // Choose a scripture for the game (simple example, could be improved with randomness or user selection)
        // To test the Proverbs scripture, you can change the following line:
        // Scripture currentScripture = scripture2;
        Scripture currentScripture = scripture1; 

        // *** End of section for exceeding requirements ***

        string userInput = "";

        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear(); // Clears the console screen
            Console.WriteLine(currentScripture.GetDisplayText()); // Displays the current scripture
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");

            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                // Hides 3 words at a time. You can adjust this number.
                currentScripture.HideRandomWords(3);
            }
        }

        // Displays the final scripture (fully hidden or as it was before 'quit')
        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
        Console.WriteLine("\nProgram ended. All words hidden or 'quit' was typed.");
        Console.ReadKey(); // Waits for a key press before closing the console
    }
}