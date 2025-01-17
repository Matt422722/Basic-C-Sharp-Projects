using System;

namespace Constructor
{

class Program
{
    // Declare a constant variable (its value cannot be changed after declaration)
    private const double Pi = 3.14159;

    static void Main()
    {
        // Declare a variable using 'var' (implicitly typed variable)
        var message = "Hello, C#!";

        // Create an instance of the Person class
        Person person = new Person("Matt", 25);

        // Print the message and person's details
        Console.WriteLine(message);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
}

