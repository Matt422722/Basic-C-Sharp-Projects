using System;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input their age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); // Read and convert the user's input to an integer

            // Ask the user to answer if they've ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine()); // Read and convert the user's input to a boolean

            // Ask the user to provide the number of speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Read and convert the user's input to an integer

            // Check, with Boolean, if the applicant meets the qualifications
            // Conditions: Over 15 years old, no DUIs, and no more than 3 speeding tickets
            bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

            // Output the qualification result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified); // Print the result (true or false)
        }
    }
}
