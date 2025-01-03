using System;

namespace MathAndComparisonOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the program title
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Input details for Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine()); // Get hourly rate for Person 1
            Console.Write("Hours worked per week? ");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine()); // Get hours worked per week for Person 1

            // Input details for Person 2
            Console.WriteLine("\nPerson 2");
            Console.Write("Hourly Rate? ");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine()); // Get hourly rate for Person 2
            Console.Write("Hours worked per week? ");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine()); // Get hours worked per week for Person 2

            // Calculate annual salary for both persons
            double annualSalary1 = hourlyRate1 * hoursWorked1 * 52; // Annual salary of Person 1
            double annualSalary2 = hourlyRate2 * hoursWorked2 * 52; // Annual salary of Person 2

            // Display the annual salaries
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Determine if Person 1 makes more money than Person 2
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2); // Output true or false
        }
    }
}
