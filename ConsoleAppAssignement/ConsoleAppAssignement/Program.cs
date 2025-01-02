using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number:");// User inputs a value
            int number = Convert.ToInt32(Console.ReadLine());// Variable for the input is created and stored
            Console.WriteLine(number * 50);// Writes the output of the math operation

            Console.WriteLine("Enter a Number:");// User inputs a value
            int number1 = Convert.ToInt32(Console.ReadLine());// Variable for the input is created and stored
            Console.WriteLine(number1 + 25);// Writes the output of the math operation

            Console.WriteLine("Enter a Number:");// User inputs a value
            double number2 = Convert.ToDouble(Console.ReadLine());// Variable for the input is created and stored
            Console.WriteLine(number2 / 12.5);// Writes the output of the math operation

            Console.WriteLine("Enter a Number:");// User inputs a value
            double number3 = Convert.ToDouble(Console.ReadLine());// Variable for the input is created and stored 
            bool isGreaterThan50 = number3 > 50; // Writes the output of the math operation
            Console.WriteLine($"Is the number greater than 50? {isGreaterThan50}");

            Console.WriteLine("Enter a Number:");// User inputs a value
            int number4 = Convert.ToInt32(Console.ReadLine());// Variable for the input is created and stored
            Console.WriteLine($"The remainder when {number4} is divided by 7 is: {number4 % 7}");// Writes the output of the math operation
        }
    }
}
