using System;
namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentTime);

            // Ask the user for a number
            Console.Write("Enter a number of hours to add: ");
            string input = Console.ReadLine();

            // Convert the user input from string to integer
            // If the conversion fails, display an error message and exit
            if (int.TryParse(input, out int hoursToAdd))
            {
                // Calculate the future time by adding the given number of hours
                DateTime futureTime = currentTime.AddHours(hoursToAdd);

                // Print the exact time it will be after X hours
                Console.WriteLine("In {0} hours, the time will be: {1}", hoursToAdd, futureTime);
            }
            else
            {
                // Display an error message if the input is not a valid number
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}

