using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a one-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Step 2: Ask the user to input some text
        Console.Write("Please enter some text to append: ");
        string userInput = Console.ReadLine();

        // Step 3: Loop to append user input to each string in the array
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += userInput;
        }

        // Step 4: Infinite loop demonstration
        while (true) // This creates an infinite loop
        {
            Console.Write("Would you like to print the updated array? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                // Step 5: Loop to print each updated string in the array
                Console.WriteLine("\nUpdated strings in the array:");
                foreach (string str in stringArray)
                {
                    Console.WriteLine(str);
                }
            }
            else if (response == "no")
            {
                // Exit the infinite loop
                Console.WriteLine("Exiting the program.");
                break; // Fix for the infinite loop
            }
            else
            {
                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
            }
        }

        // Step 6: Loop using '<' operator
        Console.WriteLine("\nLoop with '<' operator:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine($"Index {i}: {stringArray[i]}");
        }

        // Step 7: Loop using '<=' operator
        Console.WriteLine("\nLoop with '<=' operator:");
        for (int i = 0; i <= stringArray.Length - 1; i++) // Using '<=' ensures it stops at the last valid index
        {
            Console.WriteLine($"Index {i}: {stringArray[i]}");
        }

        // Step 8: Unique list of strings
        List<string> uniqueList = new List<string> { "Durian", "Melon", "Cherry", "Pineapple", "Pear" };

        // Ask the user to input text to search for in the list
        Console.Write("\nEnter text to search for in the list: ");
        string searchText = Console.ReadLine();

        // Step 9: Loop to search for the text
        bool found = false;
        for (int i = 0; i < uniqueList.Count; i++)
        { 
                if (uniqueList[i].IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Match found at index {i}: {uniqueList[i]}");
                    found = true;
                    break; // Stop the loop once a match is found
                }
            }


            // Step 10: Check if the input was not found in the list
            if (!found)
        {
            Console.WriteLine("The input is not on the list.");
        }

        // Step 11: List with duplicates
        List<string> duplicateList = new List<string> { "Apple", "Banana", "Cherry", "Apple", "Date", "Banana" };

        // Ask the user to input text to search for in the duplicate list
        Console.Write("\nEnter text to search for in the list with duplicates: ");
        string duplicateSearchText = Console.ReadLine();

        // Step 12: Loop to find all matching indices in the duplicate list
        List<int> matchingIndices = new List<int>();
        for (int i = 0; i < duplicateList.Count; i++)
        {
            if (duplicateList[i].Equals(duplicateSearchText, StringComparison.OrdinalIgnoreCase))
            {
                matchingIndices.Add(i);
            }
        }

        // Step 13: Display results or notify if no match found
        if (matchingIndices.Count > 0)
        {
            Console.WriteLine($"Matches found at indices: {string.Join(", ", matchingIndices)}");
        }
        else
        {
            Console.WriteLine("The input is not on the list.");
        }

        // Step 14: Foreach loop to identify duplicates
        // Create a HashSet to keep track of seen items
        HashSet<string> seenItems = new HashSet<string>();

        Console.WriteLine("\nEvaluating duplicates in the list:");
        foreach (string item in duplicateList)
        {
            // Check if the item has been seen before
            if (seenItems.Contains(item))
            {
                Console.WriteLine($"{item} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{item} - this item is unique");
                seenItems.Add(item); // Mark the item as seen
            }
        }

        // Pause the console so the user can see the output
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

