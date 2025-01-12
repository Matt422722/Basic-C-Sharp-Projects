// Employee class inherits from Person
using Abstract;
using System;

public class Employee : Person
{
    // Override the abstract SayName() method to provide implementation
    public override void SayName()
    {
        // Print the full name of the employee to the console
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}
