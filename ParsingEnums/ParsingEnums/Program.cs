using System;

namespace DaysOfWeekEnumExample
{
    class Program
    {
        // Define an enum to represent the days of the week
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week (example: Monday):");

            try
            {
                // Read user input and attempt to parse it into the DaysOfWeek enum
                string userInput = Console.ReadLine();

                // Use Enum.Parse to convert the input string to the corresponding enum value
                // The true argument makes the parsing case-insensitive
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If parsing is successful, display the selected day
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (Exception)
            {
                // Catch any errors (invalid input that can't be converted to the enum)
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
