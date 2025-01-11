using System;

// Declares a static class, meaning all members of the class must also be static.
public static class StaticUtilities
{
    // Static method to demonstrate overloading. This method takes one integer.
    public static int Multiply(int number)
    {
        return number * 2;
    }

    // Overloaded method with two integers.
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
}

// Defines a class with various methods to demonstrate functionality.
public class NumberProcessor
{
    // A void method that divides the input by 2 and outputs the result.
    public void DivideByTwo(int number)
    {
        int result = number / 2;
        Console.WriteLine($"The result of dividing {number} by 2 is: {result}");
    }

    // A method with an output parameter that multiplies the input by a fixed value.
    public void MultiplyByThree(int input, out int result)
    {
        result = input * 3; // Sets the output parameter.
    }
}
