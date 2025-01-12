using System;
using Polymorphism;

public class Employee : IQuittable
{
    public string Name { get; set; } // A property to hold the name of the employee

    // Constructor to initialize the Employee object
    public Employee(string name)
    {
        Name = name;
    }

    // Implementation of the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{Name} has decided to quit the job.");
    }
}

