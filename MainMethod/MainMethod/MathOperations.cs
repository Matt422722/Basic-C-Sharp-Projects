using System;

namespace MathOperationsApp
{
    // Define a class containing overloaded methods for mathematical operations
    class MathOperations
    {
        // Method 1: Takes an integer, adds 10, and returns the result
        public int PerformOperation(int number)
        {
            return number + 10; // Add 10 to the input integer and return
        }

        // Method 2: Takes a decimal, multiplies by 2, and returns the result as an integer
        public int PerformOperation(decimal number)
        {
            return (int)(number * 2); // Multiply the decimal input by 2, cast to int, and return
        }

        // Method 3: Takes a string, converts it to an integer, subtracts 5, and returns the result
        public int PerformOperation(string number)
        {
            // Convert the string to an integer if possible
            if (int.TryParse(number, out int parsedNumber))
            {
                return parsedNumber - 5; // Subtract 5 from the converted integer and return
            }
            else
            {
                throw new ArgumentException("Input string is not a valid integer."); // Handle invalid input
            }
        }
    }
}
