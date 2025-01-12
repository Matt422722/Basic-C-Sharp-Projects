using System;

namespace MethodObjectAssignment
{
    // Define the Person class
    public class Person
    {
        // Property to store the first name of the person
        public string FirstName { get; set; }

        // Property to store the last name of the person
        public string LastName { get; set; }

        // Method to print the full name to the console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
