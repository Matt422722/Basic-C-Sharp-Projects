using System;
using static CallingMethod.MathOperation;

namespace CallingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to enter a number
            Console.WriteLine("Enter an integer to perform math operations on:");

            // Read the user's input and convert it to an integer
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                // If the input is invalid, ask the user to enter a valid number
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }

            // Call the Double method and display result
            int doubled = mathOps.Double(userInput);
            Console.WriteLine($"The number doubled is: {doubled}");

            // Call the Square method and display result
            int squared = mathOps.Square(userInput);
            Console.WriteLine($"The number squared is: {squared}");

            // Call the AddTen method and display result
            int addedTen = mathOps.AddTen(userInput);
            Console.WriteLine($"The number with 10 added is: {addedTen}");
        }
    }
}
    

