using System;

namespace Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to input the first number
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine()); // Parse the input to an integer

            // Ask the user to input the second number (optional)
            Console.Write("Enter the second number (or press Enter to skip): ");
            string input = Console.ReadLine(); // Read the input as a string

            int result; // Variable to store the result

            // Check if the second number was entered
            if (string.IsNullOrEmpty(input))
            {
                // Call the method with only one parameter
                result = mathOps.PerformOperation(number1);
            }
            else
            {
                // Parse the second number and call the method with two parameters
                int number2 = int.Parse(input);
                result = mathOps.PerformOperation(number1, number2);
            }

            // Display the result
            Console.WriteLine($"The result is: {result}");
        }
    }
}
