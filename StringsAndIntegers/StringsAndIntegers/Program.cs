using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide each number in the list by
        Console.WriteLine("Enter a number to divide each element in the list by:");

        try
        {
            // Read user input
            string userInput = Console.ReadLine();

            // Attempt to parse the user input into an integer
            int divisor = int.Parse(userInput);

            // Iterate through the list and perform division
            foreach (int number in numbers)
            {
                // Divide each number by the user's input and display the result
                Console.WriteLine($"{number} divided by {divisor} equals {number / divisor}");
            }
        }
        catch (DivideByZeroException ex)
        {
            // Handle division by zero errors
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (FormatException ex)
        {
            // Handle invalid input (e.g., non-numeric input)
            Console.WriteLine("Error: You must enter a valid numeric value.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected errors
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        finally
        {
            // Code in the `finally` block executes regardless of exceptions
            Console.WriteLine("Exiting the try/catch block and continuing program execution.");
        }

        // Notify that the program execution has resumed
        Console.WriteLine("Program execution has continued.");
    }
}

