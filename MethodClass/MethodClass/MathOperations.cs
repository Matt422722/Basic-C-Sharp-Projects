using System;

namespace MathOperationExample
{
    // Define a class named MathOperations
    class MathOperations
    {
        // This method takes two integers as parameters
        // It performs a math operation (multiplication) on the first integer
        // and displays the second integer
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., double it)
            int result = num1 * 2;

            // Display the results of the operation and the second integer
            Console.WriteLine($"The result of doubling {num1} is: {result}");
            Console.WriteLine($"The second integer is: {num2}");
        }
    }
}
