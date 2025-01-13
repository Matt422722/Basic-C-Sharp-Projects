using System;
using EmployeeEqualityCheck;
namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize the first Employee object
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create and initialize the second Employee object
            Employee employee2 = new Employee
            {
                Id = 1, // Same Id as employee1
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded "==" operator
            bool areEqual = employee1 == employee2;

            // Display the result of the equality check
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");

            // Compare the two Employee objects using the overloaded "!=" operator
            bool areNotEqual = employee1 != employee2;

            // Display the result of the inequality check
            Console.WriteLine($"Are employee1 and employee2 not equal? {areNotEqual}");
        }
    }
}
    

