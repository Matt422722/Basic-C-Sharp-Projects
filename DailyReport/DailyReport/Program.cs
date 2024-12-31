using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Titles for the daily report
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            

            // Daily report questions
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // Ask for the course name and save it as a string
            Console.Write("What course are you on? ");
            string course = Console.ReadLine();

            // Ask for the page number and save it as an integer
            Console.Write("What page number? ");
            int pageNumber;
            while (!int.TryParse(Console.ReadLine(), out pageNumber))
            {
                Console.Write("Please enter a valid number: ");
            }

            // Ask if the user needs help and save it as a boolean
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp;
            while (!bool.TryParse(Console.ReadLine(), out needsHelp))
            {
                Console.Write("Please answer \"true\" or \"false\": ");
            }

            // Ask for any positive experiences and save it as a string
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            // Ask for any additional feedback and save it as a string
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Ask for hours studied and save it as a double
            Console.Write("How many hours did you study today? ");
            double hoursStudied;
            while (!double.TryParse(Console.ReadLine(), out hoursStudied))
            {
                Console.Write("Please enter a valid number of hours: ");
            }

            // Display a summary of the responses
            Console.WriteLine("\nThank you for your responses! Here's a summary:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Page Number: {pageNumber}");
            Console.WriteLine($"Needs Help: {needsHelp}");
            Console.WriteLine($"Positive Experiences: {positiveExperiences}");
            Console.WriteLine($"Additional Feedback: {feedback}");
            Console.WriteLine($"Hours Studied: {hoursStudied}");
            Console.ReadLine();
        }
    }
    }

