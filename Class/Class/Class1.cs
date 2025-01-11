using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiates the NumberProcessor class.
        NumberProcessor processor = new NumberProcessor();

        // Prompts the user to enter a number.
        Console.WriteLine("Please enter a number:");

        // Reads and parses the user's input.
        int userInput = int.Parse(Console.ReadLine());

        // Calls the DivideByTwo method to divide the input by 2 and display the result.
        processor.DivideByTwo(userInput);

        // Calls the MultiplyByThree method with an output parameter.
        processor.MultiplyByThree(userInput, out int multipliedResult);

        // Displays the result of multiplying the input by 3.
        Console.WriteLine($"The result of multiplying {userInput} by 3 is: {multipliedResult}");

        // Demonstrates the use of the static class and its overloaded methods.
        Console.WriteLine($"The result of multiplying {userInput} by 2 using the static method is: {StaticUtilities.Multiply(userInput)}");
        Console.WriteLine($"The result of multiplying {userInput} and 4 using the overloaded static method is: {StaticUtilities.Multiply(userInput, 4)}");
    }
}
