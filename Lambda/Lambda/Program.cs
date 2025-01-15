using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 10 employees with at least two employees named "Joe"
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 4, FirstName = "Emily", LastName = "White" },
            new Employee { Id = 5, FirstName = "Michael", LastName = "Johnson" },
            new Employee { Id = 6, FirstName = "Sarah", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Chris", LastName = "Wilson" },
            new Employee { Id = 8, FirstName = "Anna", LastName = "Taylor" },
            new Employee { Id = 9, FirstName = "David", LastName = "Moore" },
            new Employee { Id = 10, FirstName = "Laura", LastName = "Anderson" }
        };

            // Use a foreach loop to create a list of employees with the first name "Joe"
            List<Employee> joesWithForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe") // Check if the first name is "Joe"
                {
                    joesWithForeach.Add(employee); // Add the employee to the new list
                }
            }

            // Print the results of the foreach loop
            Console.WriteLine("Employees with the first name 'Joe' using foreach loop:");
            foreach (var joe in joesWithForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Use a lambda expression to create a list of employees with the first name "Joe"
            List<Employee> joesWithLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Print the results of the lambda expression
            Console.WriteLine("\nEmployees with the first name 'Joe' using lambda expression:");
            foreach (var joe in joesWithLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Use a lambda expression to create a list of employees with an Id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Print the results of employees with an Id greater than 5
            Console.WriteLine("\nEmployees with an Id greater than 5:");
            foreach (var employee in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
        }
    }   
}
