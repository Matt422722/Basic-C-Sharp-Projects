using System;
using MathOperationsApp;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer
            int result1 = mathOps.PerformOperation(15); // Pass an integer (15) to the method
            Console.WriteLine($"Result of integer operation: {result1}"); // Display the result

            // Call the second method with a decimal
            int result2 = mathOps.PerformOperation(5.5m); // Pass a decimal (7.5) to the method
            Console.WriteLine($"Result of decimal operation: {result2}"); // Display the result

            // Call the third method with a string
            try
            {
                int result3 = mathOps.PerformOperation("20"); // Pass a string ("20") to the method
                Console.WriteLine($"Result of string operation: {result3}"); // Display the result
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Handle and display any exceptions
            }
        }
    }
}
