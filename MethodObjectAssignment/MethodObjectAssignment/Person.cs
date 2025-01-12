using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment 
{ 
 class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee
        {
            FirstName = "Sample", // Set the first name
            LastName = "Student"  // Set the last name
        };

        // Call the SayName method from the Person class (superclass) to display the full name
        employee.SayName();
    }
  }
}
