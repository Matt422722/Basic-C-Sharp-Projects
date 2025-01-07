using System;
using System.Collections.Generic;


    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Melon", "Pear" };

            // Prompt the user to select an index for the string array
            Console.WriteLine("Select an index (0-4) for the string array:");
            if (int.TryParse(Console.ReadLine(), out int stringIndex))
            {
                // Check if the index is within the valid range
                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    Console.WriteLine($"The string at index {stringIndex} is: {stringArray[stringIndex]}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select an index within the range of the array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Create and initialize a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Prompt the user to select an index for the integer array
            Console.WriteLine("\nSelect an index (0-4) for the integer array:");
            if (int.TryParse(Console.ReadLine(), out int intIndex))
            {
                // Check if the index is within the valid range
                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    Console.WriteLine($"The integer at index {intIndex} is: {intArray[intIndex]}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select an index within the range of the array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Create and initialize a list of strings
            List<string> stringList = new List<string> { "Dog", "Cat", "Horse", "Hamster", "Bird" };

            // Prompt the user to select an index for the string list
            Console.WriteLine("\nSelect an index (0-4) for the string list:");
            if (int.TryParse(Console.ReadLine(), out int listIndex))
            {
                // Check if the index is within the valid range
                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    Console.WriteLine($"The string at index {listIndex} is: {stringList[listIndex]}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select an index within the range of the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Pause the console to allow the user to see the output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

