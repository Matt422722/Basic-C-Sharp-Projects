using System;
using Polymorphism;
class Program
{
    static void Main(string[] args)
    {
        // Create an object of the Employee class
        Employee employee = new Employee("John Doe");

        // Use polymorphism to treat the Employee object as an IQuittable object
        IQuittable quittableEmployee = employee;

        // Call the Quit() method using the IQuittable interface reference
        quittableEmployee.Quit();

        // Keep the console open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
