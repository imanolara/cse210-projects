using System;
using System.Collections.Generic; // Necessary to use List<T>
using System.Linq; // Necessary for methods like .Sum(), .Average(), .Max() if you want to use them (though we'll do them manually first)

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Declare the list to store numbers
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            int enteredNumber = -1; // Initialize with a non-zero value to enter the loop

            // Step 2: Prompt the user for numbers and add them to the list
            while (enteredNumber != 0)
            {
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();

                // Attempt to convert the user's input to an integer
                if (int.TryParse(userInput, out enteredNumber))
                {
                    if (enteredNumber != 0)
                    {
                        numbers.Add(enteredNumber);
                    }
                }
                else
                {
                    // If the user enters invalid input, inform them
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // --- Core Requirements ---

            // 3.1: Calculate the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // 3.2: Calculate the average
            // Ensure floating-point division by casting to double
            if (numbers.Count > 0) // Avoid division by zero if the list is empty
            {
                double average = (double)sum / numbers.Count;
                Console.WriteLine($"The average is: {average}");
            }
            else
            {
                Console.WriteLine("Cannot calculate average: The list is empty.");
            }

            // 3.3: Find the largest number (maximum)
            int largestNumber = int.MinValue; // Initialize with the smallest possible integer value
            if (numbers.Count > 0)
            {
                foreach (int number in numbers)
                {
                    if (number > largestNumber)
                    {
                        largestNumber = number;
                    }
                }
                Console.WriteLine($"The largest number is: {largestNumber}");
            }
            else
            {
                Console.WriteLine("Cannot find largest number: The list is empty.");
            }
            
            // --- Stretch Challenges (Optional) ---
            Console.WriteLine("\n--- Stretch Challenges ---");

            // 4.1: Find the smallest positive number (closest to zero)
            int smallestPositive = int.MaxValue; // Initialize with the largest possible integer value
            bool foundPositive = false; // Flag to track if at least one positive number was found

            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                    foundPositive = true;
                }
            }

            if (foundPositive)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered in the list.");
            }

            // 4.2: Sort the list and display it
            numbers.Sort(); // This method sorts the list in place
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Optional: You could also use LINQ methods if you're already familiar with them, they're more concise:
            // Console.WriteLine($"The sum is: {numbers.Sum()}");
            // Console.WriteLine($"The average is: {numbers.Average()}");
            // Console.WriteLine($"The largest number is: {numbers.Max()}");
        }
    }
}