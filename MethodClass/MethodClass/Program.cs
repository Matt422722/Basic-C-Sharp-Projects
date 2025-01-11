using System;
using MathOperationExample;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the method by passing in two numbers directly
            mathOperations.PerformOperation(5, 10); // Pass 5 and 10 as arguments

            // Call the method again, specifying the parameters by name
            mathOperations.PerformOperation(num1: 7, num2: 20); // Use named arguments

            // Pause the console to view the output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

