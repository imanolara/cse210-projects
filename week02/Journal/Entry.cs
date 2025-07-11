// Entry.cs
using System; // Needed for Console.WriteLine

namespace Journal // <-- ¡Importante! Asegúrate de que esta línea esté aquí.
{
    public class Entry
    {
        // Member variables (attributes) for the journal entry
        public string _date;
        public string _promptText;
        public string _entryText;

        // Method to display the entry information
        public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
            Console.WriteLine(); // Add an empty line for readability between entries
        }
    }
} // 