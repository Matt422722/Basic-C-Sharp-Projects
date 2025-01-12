using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee();

            // Set the first and last name properties of the employee object
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName() method to display the employee's full name
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
