// Journal.cs
using System;
using System.Collections.Generic; // Needed for List<T>
using System.IO; // Needed for File I/O operations (StreamWriter, StreamReader)

// !!! ASEGÚRATE DE QUE ESTA LÍNEA DE NAMESPACE ESTÁ PRESENTE Y CORRECTA !!!
namespace Journal
{
    public class Journal
    {
        // Member variable: A list to hold all journal entries
        public List<Entry> _entries = new List<Entry>();

        // Method to add a new entry to the journal
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        // Method to display all entries in the journal
        public void DisplayAllEntries()
        {
            Console.WriteLine("--- Journal Entries ---");
            foreach (Entry entry in _entries)
            {
                entry.Display(); // Call the Display method of each Entry object
            }
            Console.WriteLine("--- End of Journal ---");
        }

        // Method to save the current journal to a file
        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Write each entry to the file, using a chosen separator
                foreach (Entry entry in _entries)
                {
                    // Format: Date|PromptText|EntryText
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }

        // Method to load entries from a file into the journal
        public void LoadFromFile(string filename)
        {
            _entries.Clear(); // Clear existing entries before loading new ones

            if (!File.Exists(filename))
            {
                Console.WriteLine($"Error: File '{filename}' not found.");
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|'); // Split the line by the chosen separator

                if (parts.Length == 3) // Ensure the line has all three parts
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];
                    _entries.Add(newEntry);
                }
                else
                {
                    Console.WriteLine($"Warning: Skipping malformed line in file: {line}");
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
    }
} // !!! ASEGÚRATE DE QUE ESTA LLAVE DE CIERRE TAMBIÉN ESTÁ AQUÍ !!!