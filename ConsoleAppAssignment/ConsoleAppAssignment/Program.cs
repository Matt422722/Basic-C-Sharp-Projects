using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Prompt the user to guess a number
                Console.WriteLine("Guess a number?");

                // Convert the user input into an integer
                int number = Convert.ToInt32(Console.ReadLine());

                // Use a switch statement to check the guessed number
                switch (number)
                {
                    case 1:
                        // Inform the user if they guessed correctly
                        Console.WriteLine("Number 1 is correct!");
                        break;
                    default:
                        // Inform the user if their guess was incorrect
                        Console.WriteLine("You guessed the wrong number");
                        break;
                }

                // Boolean comparison using a while statement
                Console.WriteLine("Guess the number again (Hint: It's 5)");
                int guess;
                bool correctGuess = false; // Initialize a boolean to track correct guess

                // Keep prompting the user until they guess the correct number
                while (!correctGuess)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    // Check if the guess is correct
                    if (guess == 5)
                    {
                        Console.WriteLine("Correct! The number is 5.");
                        correctGuess = true; // Update the boolean to exit the loop since this is the right number
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess, try again.");
                    }
                }

                // Boolean comparison using a do-while statement
                Console.WriteLine("Guess the secret number (Hint: It's 7)");
                int secretGuess;
                bool guessedCorrectly = false; // Initialize another boolean to track correct guess

                // Ensure the loop executes at least once
                do
                {
                    Console.Write("Enter your guess: ");
                    secretGuess = Convert.ToInt32(Console.ReadLine());

                    // Check if the guess is correct
                    if (secretGuess == 7)
                    {
                        Console.WriteLine("Correct! The secret number is 7.");
                        guessedCorrectly = true; // Update the boolean to exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Incorrect guess, try again.");
                    }

                } while (!guessedCorrectly); // Continue until the correct guess is made

                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}
