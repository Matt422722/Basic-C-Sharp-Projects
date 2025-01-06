using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string string1 = "Hello"; // First string
            string string2 = " there"; // Second string
            string string3 = ", welcome to C#!"; // Third string

            // Concatenating the three strings
            string concatenatedString = string1 + string2 + string3;
            Console.WriteLine("Concatenated String: " + concatenatedString);

            // Convert a string to uppercase
            string lowercaseString = "this is a test string."; // Original lowercase string
            string uppercaseString = lowercaseString.ToUpper(); // Convert to uppercase
            Console.WriteLine("Uppercase String: " + uppercaseString);

            // Use a StringBuilder to build a paragraph, one sentence at a time
            StringBuilder paragraph = new StringBuilder(); // Create a new StringBuilder instance

            // Adding sentences to the StringBuilder
            paragraph.Append("C# is a powerful programming language. "); // First sentence
            paragraph.Append("It is used for developing a variety of applications. "); // Second sentence
            paragraph.Append("This includes web, mobile, desktop, and gaming applications. "); // Third sentence
            paragraph.Append("I can see why it is one of the most popular programming languages."); // Fourth sentence

            // Output the constructed paragraph
            Console.WriteLine("\nConstructed Paragraph:\n" + paragraph.ToString());

            // Keep the console open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
