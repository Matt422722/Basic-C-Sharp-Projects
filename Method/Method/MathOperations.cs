using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    // Define the class
    public class MathOperations
    {
        // Method that takes two integers, one of which is optional
        public int PerformOperation(int num1, int num2 = 0)
        {
            // Perform a simple addition and return the result
            return num1 + num2;
        }
    }
}