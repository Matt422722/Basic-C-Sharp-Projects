using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // User inputs the package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine()); // Convert the input to a double

            // Check if the weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // User inputs the package dimensions
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine()); // Convert the input to a double

            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine()); // Convert the input to a double

            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine()); // Convert the input to a double

            // Calculate the total dimensions of the package
            double dimensionTotal = width + height + length;

            // Check if the total dimensions exceed 50
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display the calculated quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");

            // Display a thank you message
            Console.WriteLine("Thank you!");
       
    }
   
}

